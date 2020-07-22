using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActYazbeeBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public static ChromeDriver driver
        {
            get;
            set;
        }

        public async void StartDriverP(string proxy)
        {

            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            ChromeOptions chromeOptions = new ChromeOptions();
            if (!string.IsNullOrEmpty(proxy))
            {
                chromeOptions.AddArgument("--proxy-server=" + proxy);
            }
            chromeOptions.AddArgument("disable-infobars");
            chromeOptions.AddArguments("--allow-file-access");
            chromeOptions.AddArgument("--disable-web-security");
            chromeOptions.AddArgument("--allow-running-insecure-content");
            driver = new ChromeDriver(chromeDriverService, chromeOptions, TimeSpan.FromMinutes(3.0));
            await Task.Delay(2000);
        }

        public static bool IsTestElementPresent(By element)
        {
            try
            {
                driver.FindElement(element);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private void txtIsimler_TextChanged(object sender, EventArgs e)
        {
            lblIsim.Text = "İsim Sayısı: " + txtIsimler.Lines.Length;
        }

        private void txtSoyisimler_TextChanged(object sender, EventArgs e)
        {
            lblSoyisim.Text = "Soysim Sayısı: " + txtSoyisimler.Lines.Length;
        }

        private async void btnBaslat_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                try
                {
                    for (int i = 0; i < txtIsimler.Lines.Length; i++)
                    {
                        StartDriverP(null);
                        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(59);
                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(59);
                        driver.Manage().Window.Size = new Size(1280, 720);
                        if (await MailCek())
                        {
                            lstLog.Items.Add(i + ". Mail yazıldı.");
                        }
                        else
                        {
                            lstLog.Items.Add(i + ". Mail işlemi hatalı");
                            driver.Quit();
                            goto label;
                        }

                        await Task.Delay(2000);
                        if (await YazbeeKayit(i))
                        {
                            lstLog.Items.Add(i + ". Kayıt işlemi başarılı.");
                        }
                        else
                        {
                            lstLog.Items.Add(i + ". Kayıt işlemi hatalı.");
                            driver.Quit();
                            goto label;
                        }

                        driver.SwitchTo().Window(driver.WindowHandles.First());
                        if (await MailDogrula())
                        {
                            lstLog.Items.Add("Mail doğruladın");
                        }
                        else
                        {
                            lstLog.Items.Add("mail doğrulanırken hata oluştu");
                            driver.Quit();
                            goto label;
                        }
                        await Task.Delay(5000);

                        if (await GirVeTakipEt())
                        {
                            lstLog.Items.Add("İşlem tamamlandı");
                        }
                        else
                        {
                            lstLog.Items.Add("işlem başarısız");
                            driver.Quit();
                            goto label;
                        }
                        await Task.Delay(5000);
                        label:
                        driver.Quit();
                    }
                }
                catch (Exception ex)
                {
                    lstLog.Items.Add("(btnBaslat) Hata: " + ex.Message);
                }
            });
        }

        public async Task<bool> MailCek()
        {
            try
            {
                driver.Navigate().GoToUrl("https://tempail.com/tr/gecici-mail/");
                await Task.Delay(2000);
                IWebElement mail = driver.FindElement(By.CssSelector("#eposta_adres"));
                string mailAdresi = mail.GetAttribute("value");
                txtMail.Text = mailAdresi;
                return true;
            }
            catch (Exception ex)
            {
                lstLog.Items.Add("(MailCek) Hata: " + ex.Message);
                return false;
            }
        }
        public async Task<bool> YazbeeKayit(int s)
        {
            try
            {
                ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
                await Task.Delay(1000);
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                await Task.Delay(1000);
                driver.Navigate().GoToUrl("https://www.instagram.com/accounts/emailsignup/?hl=tr");
                await Task.Delay(2000);
                string isim = txtIsimler.Lines[s];
                string soyisim = txtSoyisimler.Lines[s];
                string sifre = txtSifre.Text;
                string mail = txtMail.Text;
                string kullaniciAdi = isim + soyisim + txtKullaniciAdiSonu.Text;
                IWebElement name = driver.FindElement(By.Name("fullName"));
                name.SendKeys(isim);
                IWebElement username = driver.FindElement(By.Name("username"));
                username.SendKeys(kullaniciAdi);
                IWebElement email = driver.FindElement(By.Name("emailOrPhone"));
                email.SendKeys(mail);
                IWebElement password = driver.FindElement(By.Name("password"));
                password.SendKeys(sifre);
                IWebElement passwordA = driver.FindElement(By.Name("password"));
                passwordA.SendKeys(sifre);
                IWebElement btn = driver.FindElement(By.Name("submit"));
                btn.Click();
                await Task.Delay(10000);
                return true;
            }
            catch (Exception ex)
            {
                lstLog.Items.Add("(YazbeeKayit) Hata: " + ex.Message);
                return false;
            }
        }
        public async Task<bool> MailDogrula()
        {
            bool basarili = false;
            try
            {
                if (IsTestElementPresent(By.CssSelector("body > main > div.container > div > div.col-sm-12.col-md-12.col-lg-12.col-xl-8 > div.content > div.inboxWarpMain > div > div.inbox-dataList > ul > li > div:nth-child(1) > a > span.inboxSenderName")))
                {

                    IWebElement yazbeeMail = driver.FindElement(By.CssSelector("body > main > div.container > div > div.col-sm-12.col-md-12.col-lg-12.col-xl-8 > div.content > div.inboxWarpMain > div > div.inbox-dataList > ul > li > div:nth-child(1) > a > span.inboxSenderName"));
                    string ybt = yazbeeMail.Text;
                    if (ybt.ToLower() == "yazbee")
                    {
                        yazbeeMail.Click();
                        await Task.Delay(3000);
                        IWebElement dogrula = driver.FindElement(By.CssSelector("body > main > div.container > div > div.col-sm-12.col-md-12.col-lg-12.col-xl-8 > div.content > div.inboxWarpMain > div > div.inbox-data-content > div.inbox-data-content-intro > div > div > div > div:nth-child(4) > div > div > div:nth-child(3) > div > a"));
                        string aa = dogrula.GetAttribute("href");
                        driver.Navigate().GoToUrl(aa);
                        basarili = true;
                    }
                    else
                    {
                        lstLog.Items.Add("maile tıklanamadı");
                    }
                }
                else
                {
                    basarili = false;
                }

            }
            catch (Exception ex)
            {
                lstLog.Items.Add("(MailDogrula) Hata: " + ex.Message);
                basarili = false;
            }
            return basarili;
        }

        public async Task<bool> GirVeTakipEt()
        {
            bool basarili = false;
            try
            {
                ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
                await Task.Delay(1000);
                driver.SwitchTo().Window(driver.WindowHandles.Last());
                await Task.Delay(1000);
                driver.Navigate().GoToUrl("https://yazbee.com/login");
                await Task.Delay(2000);
                IWebElement email = driver.FindElement(By.Name("Email"));
                email.SendKeys(txtMail.Text);
                IWebElement sifre = driver.FindElement(By.Name("Password"));
                sifre.SendKeys(txtSifre.Text);
                IWebElement btn = driver.FindElement(By.Name("btnLoginSubmit"));
                btn.Click();
                await Task.Delay(5000);
                driver.Navigate().GoToUrl("https://yazbee.com/" + txtTakip.Text);
                await Task.Delay(2000);
                IWebElement follow = driver.FindElement(By.CssSelector("body > div.profile_container > div.profile_specs.showonpc > div.specs_right > div > div.followbutton"));
                follow.Click();
                basarili = true;
            }
            catch (Exception ex)
            {
                lstLog.Items.Add("(GveT) Hata: " + ex.Message);
                basarili = false;
            }
            return basarili;
        }
    }
}
