using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace telekomAidatTakipCron
{
    class Program
    {
        //Smpt server
        public const string GMAIL_SERVER = "smtp.gmail.com";
        static SmtpClient mailServer = new SmtpClient(GMAIL_SERVER, PORT);

        static string from = "telekomstaj2017@gmail.com";
        //Connecting port
        public const int PORT = 587;
        public static string connectstring = "Data Source=207.154.210.112;Database=telekomAidat;User=telekom; Password ='telekom';";

        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0] == "add")
                {
                    TaskService.Instance.AddTask("Telekom Aidat Cron", QuickTriggerType.Logon, Assembly.GetExecutingAssembly().Location);

                }
                else if (args[0] == "del")
                {
                    Microsoft.Win32.TaskScheduler.Task task = TaskService.Instance.FindTask("Telekom Aidat Cron");
                    if (task != null)
                        task.Enabled = false;
                }
            }
            else
            {

                Database db = new Database();
                var kontrol = db.DataOkuTek("select tarih from cron", "tarih");
                db.Kapat();


                db = new Database();
                if (DateTime.Today.ToString() != kontrol)
                {

                    mailServer.EnableSsl = true;
                    mailServer.Credentials = new System.Net.NetworkCredential("telekomstaj2017@gmail.com", "telekom123");

                    List<Gonderi> gonderiler = TarihKontrol();

                    foreach (Gonderi gonderi in gonderiler)
                    {
                        MailTekliGonder(gonderi.mail, gonderi.baslik, gonderi.icerik);
                    }
                    gonderiler.Clear();

                    List<Gonderi> dogumGunuGonderiler = dogumGunuTarihKontrol();

                    foreach (Gonderi gonderi in dogumGunuGonderiler)
                    {
                        MailTekliGonder(gonderi.mail, gonderi.baslik, gonderi.icerik);
                    }

                    db.Sorgu("update cron set tarih=@0", DateTime.Today); // sona koydukki tamamlanınca işaret koysun
                }



                //db.Sorgu("update cron set tarih=@0", DateTime.Today.AddDays(-1));
            }
        }

        static void MailTekliGonder(string mail, string baslik, string icerik)
        {
            MailMessage msg = new MailMessage(from, mail);

            try
            {
                //mailin başlığı.
                msg.Subject = baslik;
                //mailin içeiği.
                msg.Body = icerik;
                mailServer.Send(msg);
            }
            catch
            {
                //Console.WriteLine("Mail gönderilemedi hata: " + ex);
            }

        }


        //Doğum günü kutlaması.
        static private List<Gonderi> dogumGunuTarihKontrol()
        {

            string mesaj = "";
            string degisecekAdSoyad = "";
            string degisecekSicilNo = "";
            string degisecekIlAdi = "";
            string degisecekMudurlukAdi = "";
            string degisecekBirimAdi = "";

            Database db = new Database();
            List<Gonderi> gonderiler = new List<Gonderi>();
            var data = db.DataOku("select a.sicilNo, a.email, u.adSoyad,i.ilAdi, m.MudurlukAdi, b.birimAdi" +
            " from Adres a, Uyeler u, Mudurluk m, il i,Birim b,nufusBilgileri nfb" +
            " WHERE email is not null" +
            " AND email != ''" +
            " AND a.sicilNo = u.sicilNo" +
            " AND u.MudurlukNo = m.MudurlukNo" +
            " AND i.ilNo = u.ilNo" +
            " AND b.birimNo = u.birimNo" +
            " AND nfb.dogumTarihi LIKE '%" + DateTime.Now.ToString("MM-dd") + "%'" +
            " AND nfb.sicilNo = u.sicilNo");

            Database db2 = new Database();
            var data2 = db2.DataOku("select baslik,mesaj,tarih from OzelGunler WHERE ozelGunNo = 10");

            while (data2.Read())
            {
                while (data.Read())
                {
                    degisecekAdSoyad = data["adSoyad"].ToString();
                    degisecekSicilNo = data["sicilNo"].ToString();
                    degisecekIlAdi = data["ilAdi"].ToString();
                    degisecekMudurlukAdi = data["MudurlukAdi"].ToString();
                    degisecekBirimAdi = data["BirimAdi"].ToString();

                    mesaj = data2["mesaj"].ToString();
                    mesaj = mesaj.Replace("%adsoyad%", degisecekAdSoyad);
                    mesaj = mesaj.Replace("%sicilno%", degisecekSicilNo);
                    mesaj = mesaj.Replace("%sehir%", degisecekIlAdi);
                    mesaj = mesaj.Replace("%mudurluk%", degisecekMudurlukAdi);
                    mesaj = mesaj.Replace("%birim%", degisecekBirimAdi);
                    gonderiler.Add(new Gonderi((data2["baslik"]).ToString(), mesaj, data["email"].ToString()));


                }
            }
            db.Kapat();
            db2.Kapat();
            return gonderiler;
        }


        //class
        class Gonderi
        {
            public string baslik;
            public string icerik;
            public string mail;

            public Gonderi(string baslik, string icerik, string mail)
            {
                this.baslik = baslik;
                this.icerik = icerik;
                this.mail = mail;
            }
        }

        //end class
        static private List<Gonderi> TarihKontrol()
        {

            string mesaj = "";
            string degisecekAdSoyad = "";
            string degisecekSicilNo = "";
            string degisecekIlAdi = "";
            string degisecekMudurlukAdi = "";
            string degisecekBirimAdi = "";

            List<Gonderi> gonderiler = new List<Gonderi>();

            Database db2 = new Database();
            var data2 = db2.DataOku("select baslik,mesaj,tarih from OzelGunler WHERE tarih LIKE '%" + DateTime.Now.ToString("MM-dd") + "%' AND ozelGunNo != 10");

            while (data2.Read())
            {
                Database db = new Database();
                var data = db.DataOku("select a.sicilNo, a.email, u.adSoyad,i.ilAdi, m.MudurlukAdi, b.birimAdi" +
                    " from Adres a, Uyeler u, Mudurluk m, il i,Birim b" +
                    " WHERE email is not null" +
                    " AND email != ''" +
                    " AND a.sicilNo = u.sicilNo" +
                    " AND u.MudurlukNo = m.MudurlukNo" +
                    " AND i.ilNo = u.ilNo" +
                    " AND b.birimNo = u.birimNo");

                while (data.Read())
                {
                    degisecekAdSoyad = data["adSoyad"].ToString();
                    degisecekSicilNo = data["sicilNo"].ToString();
                    degisecekIlAdi = data["ilAdi"].ToString();
                    degisecekMudurlukAdi = data["MudurlukAdi"].ToString();
                    degisecekBirimAdi = data["BirimAdi"].ToString();

                    mesaj = data2["mesaj"].ToString();
                    mesaj = mesaj.Replace("%adsoyad%", degisecekAdSoyad);
                    mesaj = mesaj.Replace("%sicilno%", degisecekSicilNo);
                    mesaj = mesaj.Replace("%sehir%", degisecekIlAdi);
                    mesaj = mesaj.Replace("%mudurluk%", degisecekMudurlukAdi);
                    mesaj = mesaj.Replace("%birim%", degisecekBirimAdi);
                    gonderiler.Add(new Gonderi((data2["baslik"]).ToString(), mesaj, data["email"].ToString()));

                }
                db.Kapat();
            }


            db2.Kapat();
            return gonderiler;
        }
    }
}
    