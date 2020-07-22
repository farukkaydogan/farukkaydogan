using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace WindowsFormsApp1
{
    public partial class İnsagram : Form
    {

        public İnsagram()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        public static ChromeDriver drv
        {
            get;
            set;
        }

        public int sayac;
        //public string isimler
        //{
        //    get { return isimler; }

        //    set { isimler = value; }

        //}
        public string[] lines;
        private void İnsagram_Load(object sender, EventArgs e)
        {
            proxycek2();
            lines = System.IO.File.ReadAllLines(@"C:\Users\faruk\Desktop\isimler");
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
            drv = new ChromeDriver(chromeDriverService, chromeOptions, TimeSpan.FromMinutes(3.0));
            await Task.Delay(2000);
        }

        private async void proxycek2()
        {
            try
            { await Task.Delay(1000);
                ChromeOptions options = new ChromeOptions();
                options.AddArguments(@"user-data-dir=" + Application.StartupPath + "\\profile");
                options.AddExcludedArgument("enable-automation");
                ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;
                IWebDriver adriver = new ChromeDriver(service, options);
                adriver.Navigate().GoToUrl("https://free-proxy-list.net/");
                Thread.Sleep(1500);
                adriver.FindElement(By.XPath("//select[@name='proxylisttable_length']//option[contains(text(),'80')]")).Click();
                Thread.Sleep(1000);
                for (int i = 1; i < 81; i++)
                {
                    IWebElement element = adriver.FindElement(By.XPath("/html[1]/body[1]/section[1]/div[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[" + i + "]/td[1]"));
                    IWebElement element1 = adriver.FindElement(By.XPath("/html[1]/body[1]/section[1]/div[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[" + i + "]/td[2]"));
                    ANNEM.Items.Add(element.Text + ":" + element1.Text);
                }
                adriver.FindElement(By.XPath("/html[1]/body[1]/section[1]/div[1]/div[2]/div[1]/div[3]/div[2]/div[1]/ul[1]/li[4]/a[1]")).Click();
                Thread.Sleep(1000);
                for (int i = 1; i < 81; i++)
                {
                    IWebElement element = adriver.FindElement(By.XPath("/html[1]/body[1]/section[1]/div[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[" + i + "]/td[1]"));
                    IWebElement element1 = adriver.FindElement(By.XPath("/html[1]/body[1]/section[1]/div[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[" + i + "]/td[2]"));
                    ANNEM.Items.Add(element.Text + ":" + element1.Text);
                }
                adriver.FindElement(By.XPath("/html[1]/body[1]/section[1]/div[1]/div[2]/div[1]/div[3]/div[2]/div[1]/ul[1]/li[5]/a[1]")).Click();
                Thread.Sleep(1000);
                for (int i = 1; i < 81; i++)
                {
                    IWebElement element = adriver.FindElement(By.XPath("/html[1]/body[1]/section[1]/div[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[" + i + "]/td[1]"));
                    IWebElement element1 = adriver.FindElement(By.XPath("/html[1]/body[1]/section[1]/div[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[" + i + "]/td[2]"));
                    ANNEM.Items.Add(element.Text + ":" + element1.Text);

                }

                adriver.FindElement(By.XPath("/html[1]/body[1]/section[1]/div[1]/div[2]/div[1]/div[3]/div[2]/div[1]/ul[1]/li[6]/a[1]")).Click();
                Thread.Sleep(1000);
                for (int i = 1; i < 81; i++)
                {
                    IWebElement element = adriver.FindElement(By.XPath("/html[1]/body[1]/section[1]/div[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[" + i + "]/td[1]"));
                    IWebElement element1 = adriver.FindElement(By.XPath("/html[1]/body[1]/section[1]/div[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[" + i + "]/td[2]"));
                    ANNEM.Items.Add(element.Text + ":" + element1.Text);
                    adriver.Quit();
                }
                baslat();

            }
            catch (Exception)
            {
            }

        }


        string url = "https://www.instagram.com/accounts/emailsignup/?hl=tr";
        string url2 = "https://tempail.com/tr/gecici-mail/";


        public async void baslat()
        {
            await Task.Run(async () =>
            {
                try
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        StartDriverP(ANNEM.Items[sayac + 1].ToString());
                        drv.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(59);
                        drv.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(59);
                        if (await Email_cek())
                        {
                        }
                        else
                        {
                            drv.Quit();
                        }

                        await Task.Delay(2000);
                        if (await accountacıcı())
                        {
                        }
                        else
                        {
                            drv.Quit();
                        }

                        drv.SwitchTo().Window(drv.WindowHandles.First());

                        await Task.Delay(5000);

                        /* if (await GirVeTakipEt())
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
                         */
                        drv.Quit();
                    }
                }
                catch (Exception ex)
                {
                }
            });
        }
        private async void button3_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                try
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        StartDriverP(ANNEM.Items[sayac + 1].ToString());
                        drv.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(59);
                        drv.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(59);
                        if (await Email_cek())
                        {
                        }
                        else
                        {
                            drv.Quit();
                        }

                        await Task.Delay(2000);
                        if (await accountacıcı())
                        {
                        }
                        else
                        {
                            drv.Quit();
                        }

                        drv.SwitchTo().Window(drv.WindowHandles.First());
                       
                        await Task.Delay(5000);

                       /* if (await GirVeTakipEt())
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
                        */drv.Quit(); 
                    }
                }
                catch (Exception ex)
                {
                }
            });
        }

   

        private async Task<bool> accountacıcı()
        {
            ((IJavaScriptExecutor)drv).ExecuteScript("window.open();");
            await Task.Delay(1000);
            drv.SwitchTo().Window(drv.WindowHandles.Last());
            await Task.Delay(1000);


            drv.Navigate().GoToUrl(url);
            Thread.Sleep(3000);
            Random rnd = new Random();
            string dizi="";

            for (int i = 0; i < 10; i++)
            {
                dizi += rnd.Next(0, 10);        
            }            string EPosta = txtMail;
            string isim = lines[sayac]+lines[sayac+1]+lines[sayac+2];
            string soyisim = "";
            string AdıSoyadı = isim+soyisim;

            string kullanıcıadı = AdıSoyadı +dizi;
            string şifre = "123456789Asd.";

           drv.FindElements(By.XPath("//input[@class='_2hvTZ pexuQ zyHYP']"))[0].SendKeys(EPosta);Thread.Sleep(1000);
           drv.FindElements(By.XPath("//input[@class='_2hvTZ pexuQ zyHYP']"))[1].SendKeys(kullanıcıadı); Thread.Sleep(000);
           IWebElement full = drv.FindElement(By.Name("fullName"));
            full.SendKeys(AdıSoyadı); Thread.Sleep(1000);

            drv.FindElements(By.XPath("//input[@class='_2hvTZ pexuQ zyHYP']"))[2].SendKeys(şifre); Thread.Sleep(1000);
            drv.FindElements(By.XPath("//button[@class='sqdOP yWX7d    y3zKF     ']"))[0].Click(); Thread.Sleep(1000);

            drv.FindElements(By.XPath("//button[@class='sqdOP  L3NKy   y3zKF     ']"))[1].Click();
        
            MessageBox.Show("Hesabınız açıldı");
            sayac++;


            return true;
        }
        public string txtMail;
        private async Task<bool> Email_cek()
        {
          await Task.Delay(3000);
            drv.Navigate().GoToUrl(url2);
            Thread.Sleep(3000);
            IWebElement mail = drv.FindElement(By.CssSelector("#eposta_adres"));
            string mailAdresi = mail.GetAttribute("value");
            txtMail = mailAdresi;
            return true ;

        }
        
        private void İnsagram_FormClosing(object sender, FormClosingEventArgs e)
        {
           

        }

       private void İsim(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }      
        public void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
         
            
        }

        public void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
