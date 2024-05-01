using Newtonsoft.Json;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KilsanPlcNetsisWindowsService
{
    public partial class Service1 : ServiceBase
    {

#if DEBUG
        private static string ipAddress = "176.235.180.254:7070";
#else
        private static string ipAddress = "10.1.1.27:7070"; // "176.235.180.254:7070";
#endif
        private static string server = "10.1.1.27";
        private static string database = "TESTKLS23";
        private static string uid = "ketencek2023";
        private static string password = "ketencek2023";
        public static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                logger.Info(" KilsanPlcNetsis Windows Service BEGIN ");

                //CRONJOB Quarz template
                Common.Logging.LogManager.Adapter = new Common.Logging.Simple.ConsoleOutLoggerFactoryAdapter { Level = Common.Logging.LogLevel.Info };

                // Grab the Scheduler instance from the Factory 
                

                // and start it off
                scheduler.Start();

#if (DEBUG)
                IJobDetail job = JobBuilder.Create<Vardiya_1>()
                   .WithIdentity("job1", "group1")
                   .Build();
                ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity("trigger1", "group1")
                    .WithCronSchedule("59 * * * * ?")
                    .ForJob("job1", "group1")
                    .Build();
                scheduler.ScheduleJob(job, trigger);
#else
                // 02:00
                IJobDetail job = JobBuilder.Create<Vardiya_1>()
                    .WithIdentity("job1", "group1")
                    .Build();
                ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity("trigger1", "group1")
                    .WithCronSchedule("55 59 1 * * ?")
                    .ForJob("job1", "group1")
                    .Build();
                scheduler.ScheduleJob(job, trigger);

                // 04:00
                IJobDetail job2 = JobBuilder.Create<Vardiya_1>()
                    .WithIdentity("job2", "group2")
                    .Build();
                ITrigger trigger2 = TriggerBuilder.Create()
                    .WithIdentity("trigger2", "group2")
                    .WithCronSchedule("55 59 3 * * ?")
                    .ForJob("job2", "group2")
                    .Build();
                scheduler.ScheduleJob(job2, trigger2);

                // 06:00
                IJobDetail job3 = JobBuilder.Create<Vardiya_1>()
                    .WithIdentity("job3", "group3")
                    .Build();
                ITrigger trigger3 = TriggerBuilder.Create()
                    .WithIdentity("trigger3", "group3")
                    .WithCronSchedule("55 59 5 * * ?")
                    .ForJob("job3", "group3")
                    .Build();
                scheduler.ScheduleJob(job3, trigger3);

                // 08:00
                IJobDetail job4 = JobBuilder.Create<Vardiya_1>()
                    .WithIdentity("job4", "group4")
                    .Build();
                ITrigger trigger4 = TriggerBuilder.Create()
                    .WithIdentity("trigger4", "group4")
                    .WithCronSchedule("55 59 7 * * ?")
                    .ForJob("job4", "group4")
                    .Build();
                scheduler.ScheduleJob(job4, trigger4);

                // 10:00
                IJobDetail job5 = JobBuilder.Create<Vardiya_2>()
                    .WithIdentity("job5", "group5")
                    .Build();
                ITrigger trigger5 = TriggerBuilder.Create()
                    .WithIdentity("trigger5", "group5")
                    .WithCronSchedule("55 59 9 * * ?")
                    .ForJob("job5", "group5")
                    .Build();
                scheduler.ScheduleJob(job5, trigger5);

                // 12:00
                IJobDetail job6 = JobBuilder.Create<Vardiya_2>()
                    .WithIdentity("job6", "group6")
                    .Build();
                ITrigger trigger6 = TriggerBuilder.Create()
                    .WithIdentity("trigger6", "group6")
                    .WithCronSchedule("55 59 11 * * ?")
                    .ForJob("job6", "group6")
                    .Build();
                scheduler.ScheduleJob(job6, trigger6);

                // 14:00
                IJobDetail job7 = JobBuilder.Create<Vardiya_2>()
                    .WithIdentity("job7", "group7")
                    .Build();
                ITrigger trigger7 = TriggerBuilder.Create()
                    .WithIdentity("trigger7", "group7")
                    .WithCronSchedule("55 59 13 * * ?")
                    .ForJob("job7", "group7")
                    .Build();
                scheduler.ScheduleJob(job7, trigger7);

                // 16:00
                IJobDetail job8 = JobBuilder.Create<Vardiya_2>()
                    .WithIdentity("job8", "group8")
                    .Build();
                ITrigger trigger8 = TriggerBuilder.Create()
                    .WithIdentity("trigger8", "group8")
                    .WithCronSchedule("55 59 15 * * ?")
                    .ForJob("job8", "group8")
                    .Build();
                scheduler.ScheduleJob(job8, trigger8);

                // 18:00
                IJobDetail job9 = JobBuilder.Create<Vardiya_3>()
                    .WithIdentity("job9", "group9")
                    .Build();
                ITrigger trigger9 = TriggerBuilder.Create()
                    .WithIdentity("trigger9", "group9")
                    .WithCronSchedule("55 59 17 * * ?")
                    .ForJob("job9", "group9")
                    .Build();
                scheduler.ScheduleJob(job9, trigger9);

                // 20:00
                IJobDetail job10 = JobBuilder.Create<Vardiya_3>()
                    .WithIdentity("job10", "group10")
                    .Build();
                ITrigger trigger10 = TriggerBuilder.Create()
                    .WithIdentity("trigger10", "group10")
                    .WithCronSchedule("55 59 19 * * ?")
                    .ForJob("job10", "group10")
                    .Build();
                scheduler.ScheduleJob(job10, trigger10);

                // 22:00
                IJobDetail job11 = JobBuilder.Create<Vardiya_3>()
                    .WithIdentity("job11", "group11")
                    .Build();
                ITrigger trigger11 = TriggerBuilder.Create()
                    .WithIdentity("trigger11", "group11")
                    .WithCronSchedule("55 59 21 * * ?")
                    .ForJob("job11", "group11")
                    .Build();
                scheduler.ScheduleJob(job11, trigger11);

                // 00:00
                IJobDetail job12 = JobBuilder.Create<Vardiya_3>()
                    .WithIdentity("job12", "group12")
                    .Build();
                ITrigger trigger12 = TriggerBuilder.Create()
                    .WithIdentity("trigger12", "group12")
                    .WithCronSchedule("55 59 23 * * ?")
                    .ForJob("job12", "group12")
                    .Build();
                scheduler.ScheduleJob(job12, trigger12);
#endif
                // some sleep to show what's happening
                Thread.Sleep(TimeSpan.FromSeconds(60));

                //// and last shut down the scheduler when you are ready to close your program
                //scheduler.Shutdown();
            }
            catch (SchedulerException se)
            {
                logger.Error(se, " OnStart()");
            }
        }

        protected override void OnStop()
        {
            try
            {
                logger.Info(" KilsanPlcNetsis Windows Service Manuel Stoped!");
                scheduler.Shutdown();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "");
            }
        }

        public class Vardiya_1 : IJob
        {
            public void Execute(IJobExecutionContext context)
            {
                try
                {
                    Vardiya("1");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message + " " + DateTime.Now.ToLongTimeString());
                    logger.Error(ex, "");
                }
            }
        }

        public class Vardiya_2 : IJob
        {
            public void Execute(IJobExecutionContext context)
            {
                try
                {
                    Vardiya("2");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message + " " + DateTime.Now.ToLongTimeString());
                    logger.Error(ex, "");
                }
            }
        }

        public class Vardiya_3 : IJob
        {
            public void Execute(IJobExecutionContext context)
            {
                try
                {
                    Vardiya("3");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message + " " + DateTime.Now.ToLongTimeString());
                    logger.Error(ex, "");
                }
            }
        }

        private static async void Vardiya(string v)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = get_sp_ketencekMrp_plc_data_N();

                //string tokenKey = @"AQAAANCMnd8BFdERjHoAwE_Cl-sBAAAAt6lx49pD10mQouHnLgWrsgAAAAACAAAAAAAQZgAAAAEAACAAAADsVnECclPXH_KmbH1sZwIdmbJb7pmsoeYy71jt9_wABgAAAAAOgAAAAAIAACAAAABJ8pLPHYAx3DJsTaQAG_e1Cc5hUl8P-POjZeior2cJNkABAADHRuhiT2K2q34YutMI5OnslpSeSvMljS5sZ4TYyLwXy_juDjRb5s1tNCdKQ0dWX5QNKjOL-vnkgxNATA3Psnh5VDidst1sve9pdMXy1eTgYZGyzpuJ2ArYmxP7oIr-pMX4Hc1e_OrK3iQ3dlSQb9NQxjhw6btfjvozQ8D31VKl61CJHQTpn8JoWN6tR5zEm8IDnuuB23Gc1ypi42gIx-5z6BrGcliG2O4BGavEW1VMm_qRqTqDC3fKDUb5EK3dCnm9ksboguk3iLh9S6oinx4mHFr1HaEh9LpS0iqS05TsscwBOy_qXwMwL9AqanuG77L_ZU3c4VtOUjg7xSksEUaioYLmClmn81xUYiaiK5AUUTjpCT3pIW8946FQqQiJ82ncZnq1nB6n34OMS2ddnU0ef1MqzlzFkDMJiY3mPTXM10AAAABqTKyzQWf6ou8JzwxisPdldvKE4FVszKObfhVrH8N51Wmu_Y0qe1zOCiL3QxDBt-KhI8XvslN1EYKhYwBDmTuV";//
                string tokenKey = await TokenCall();

                foreach (DataRow item in dt.Rows)
                {
                    string data_tarih = ParseDateTimeToSQLString(Convert.ToDateTime(item[5].ToString())); //sql den gelen veri tarihi
                    string topic = item[6].ToString();
                    string[] topic_ = topic.Split('_');
                    string topic_1 = topic_[0].ToString();
                    string topic_2 = topic_[1].ToString();
                    string tesis_1 = "";
                    string tesis_2 = "";

                    if (topic_1 == "Pak1")
                        tesis_1 = "1";// topic_1.Replace("Pak1", "1");
                    else if (topic_1 == "Pak2")
                        tesis_1 = "2";// topic_1.Replace("Pak2", "2-");

                    if (topic_2 == "H1")
                        tesis_2 = "1";// topic_2.Replace("H1", "1");
                    else if (topic_2 == "H2")
                        tesis_2 = "2";// topic_2.Replace("H2", "2");

                    string aciklama = "T:" + tesis_1 + tesis_2 + "-V:" + v + "-E:PLC"; //"Ket-I" + item[0].ToString() + "N" + item[1].ToString() + "C" + item[2].ToString();
                    string ks_kodu = item[3].ToString();// "100";
                    string miktar = item[2].ToString();// "5.0";
                    string depo_kodu = item[4].ToString();// "10";
                    string stok_kodu = item[1].ToString();// "11001";
                    string FATIRS_NO = DateTime.Now.ToString("dd") +
                        DateTime.Now.ToString("MM") +
                        DateTime.Now.ToString("yy") +
                        DateTime.Now.ToString("HH") +
                        DateTime.Now.ToString("mm") +
                        DateTime.Now.ToString("ss") +
                        "00" +
                        "P";

                    Console.WriteLine(item[1].ToString() + " Stok Kodulu ürün aktarılıyor... " + DateTime.Now.ToLongTimeString());

                    await ItemSlipsPost(tokenKey, data_tarih, ParseDateTimeToSQLString(DateTime.Now), aciklama, ks_kodu, miktar, depo_kodu, stok_kodu, item[0].ToString(), FATIRS_NO, topic);

                    Console.WriteLine(item[1].ToString() + " Stok Kodulu ürün aktarımı tamamlandı. " + DateTime.Now.ToLongTimeString());
                }

                Console.WriteLine("Netsis API aktarımı tamamlandı. " + DateTime.Now.ToLongTimeString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message + " " + DateTime.Now.ToLongTimeString());
                logger.Error(ex, "");
            }
        }

        private static DataTable get_sp_ketencekMrp_plc_data_N()
        {
            DataTable table = new DataTable();
            try
            {
                using (var con = new SqlConnection("server=" + server + ";database=" + database + ";user=" + uid + ";password=" + password + ";"))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    using (var cmd = new SqlCommand("sp_ketencekMrp_plc_data_N", con))
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@DateAndTime", DateTime.Now).SqlDbType = SqlDbType.DateTime;

                        da.Fill(table);
                    }
                }

                return table;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "");
                return table;
            }
        }

        /// <summary>
        /// Sql tipinde string DateTime dönüştürme için kullanılır.Parametre olarak değerleri DateTime şeklinde alır.
        /// </summary>
        public static string ParseDateTimeToSQLString(DateTime TarihSaat)
        {
            //1987-11-01 19:58:36.080
            try
            {
                string Gun = TarihSaat.Day.ToString("00");
                string Ay = TarihSaat.Month.ToString("00");
                string Yil = TarihSaat.Year.ToString("0000");
                string Saat = TarihSaat.Hour.ToString("00");
                string Dakika = TarihSaat.Minute.ToString("00");
                string Saniye = TarihSaat.Second.ToString("00");
                string Salise = TarihSaat.Millisecond.ToString("000");

                if (Saat.Length < 3)
                    Saat = ParseInt(Saat).ToString("00");
                else
                    Saat = "00";

                if (Dakika.Length < 3)
                    Dakika = ParseInt(Dakika).ToString("00");
                else
                    Dakika = "00";

                if (Saniye.Length < 3)
                    Saniye = ParseInt(Saniye).ToString("00");
                else
                    Saniye = "00";

                if (Salise.Length < 4)
                    Salise = ParseInt(Salise).ToString("000");
                else
                    Salise = "000";

                return "" + ParseInt(Yil).ToString("0000") + "-" + ParseInt(Ay).ToString("00") + "-" + ParseInt(Gun).ToString("00") + " " + Saat + ":" + Dakika + ":" + Saniye + "";
            }
            catch { }
            return "";
        }

        /// <summary>
        /// Integer dönüştürme için kullanılır.
        /// </summary>
        public static int ParseInt(object o)
        {
            int i = 0;

            try
            {
                i = Convert.ToInt32(o);
            }
            catch { }
            return i;
        }

        public static async Task<String> TokenCall()
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Post, "http://" + ipAddress + "/api/v2/token");
                var collection = new List<KeyValuePair<string, string>>();
                collection.Add(new KeyValuePair<string, string>("grant_type", "password"));
                collection.Add(new KeyValuePair<string, string>("branchcode", "0"));
                collection.Add(new KeyValuePair<string, string>("password", "K1lsaN_5"));
                collection.Add(new KeyValuePair<string, string>("username", "ketencek5"));
                collection.Add(new KeyValuePair<string, string>("dbname", "TESTKLS23"));
                collection.Add(new KeyValuePair<string, string>("dbuser", "TEMELSET"));
                collection.Add(new KeyValuePair<string, string>("dbpassword", ""));

                var content = new FormUrlEncodedContent(collection);
                request.Content = content;

                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                string result = await response.Content.ReadAsStringAsync();

                KilsanToken kilsanToken = JsonConvert.DeserializeObject<KilsanToken>(result); //System.Text.Json.JsonSerializer.Serialize(result);

                return kilsanToken.access_token;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "");
                return "";
            }
        }

        class KilsanToken
        {
            public string access_token { get; set; }
            public string token_type { get; set; }
            public int expires_in { get; set; }
            public string refresh_token { get; set; }
            public string client_id { get; set; }
            public string username { get; set; }
            public string branchcode { get; set; }
            public string dbname { get; set; }
            public string jlogin { get; set; }
            public string issued { get; set; }
            public string expires { get; set; }
        }

        public static async Task<String> ItemSlipsPost(string token, string data_tarih, string ENTEGRE_TRH, string aciklama, string ks_kodu, string miktar, string depo_kodu, string stok_kodu,
            string product_id, string FATIRS_NO, string topic)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Post, "http://" + ipAddress + "/api/v2/ItemSlips");
                request.Headers.Add("Authorization", "Bearer " + token + "");
                string data = "{\r\n    \"Seri\": \"" + FATIRS_NO + "\", \r\n     \"FatUst\": {\r\n        \"CariKod\": \"Uretim\", \n        \"Tarih\": \"" + data_tarih + "\", \n    \"FATIRS_NO\": \"" + FATIRS_NO + "\", \n     \"ENTEGRE_TRH\": \"" + ENTEGRE_TRH + "\", \n        \"KDV_DAHILMI\": false,\n        \"AMBHARTUR\": 2,\n        \"CikisYeri\": 4,\n        \"FiiliTarih\": \"" + ENTEGRE_TRH + "\", \n        \"Aciklama\": \"" + aciklama + "\", \r\n        \"KOD2\" : \"S\",\n        \"KS_KODU\" : \"" + ks_kodu + "\"\n    },\r\n    \"Use64BitService\": false,\n    \"FaturaTip\": 8,\n    \"Kalems\":[\r\n        {\r\n            \"KosulMalFazlasiIsle\":false,\n            \"StokKodu\": \"" + stok_kodu + "\",\n            \"STra_GCMIK\":" + miktar + ",\n            \"STra_BF\":0,\n            \"ReferansKodu\":\"3\",\n            \"DEPO_KODU\":" + depo_kodu + " \n        }\r\n     ]\r\n}\r\n";

                var content = new StringContent(data, null, "application/json");
                request.Content = content;

                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                string result = await response.Content.ReadAsStringAsync();

                ItemSlips itemSlips = JsonConvert.DeserializeObject<ItemSlips>(result); //System.Text.Json.JsonSerializer.Serialize(result);

                //sql e verileri göndereceke sp
                set_usp_ketencekMrp_plc_data_N(product_id, stok_kodu, itemSlips.Data.FatUst.FATIRS_NO, Convert.ToInt32(miktar), DateTime.Now,
                    aciklama, itemSlips.Data.FaturaTip.ToString(), ks_kodu, itemSlips.Data.FatUst.KOD2, depo_kodu, "", "", itemSlips.Data.Kalems.First().ReferansKodu,
                    itemSlips.Data.FatUst.AMBHARTUR.ToString(), itemSlips.Data.FatUst.CariKod, Convert.ToDateTime(data_tarih), topic);

                return itemSlips.Data.FatUst.FATIRS_NO;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "");
                return "";
            }
        }

        public class ItemSlips
        {
            public Meta Meta { get; set; }
            public bool IsSuccessful { get; set; }
            public Data Data { get; set; }
        }

        public class Meta
        {
            public string Href { get; set; }
            public string MediaType { get; set; }
            public string ApiVersion { get; set; }
        }

        public class Data
        {
            public object Seri { get; set; }
            public FatUst FatUst { get; set; }
            public EIrsEkBilgi EIrsEkBilgi { get; set; }
            public HalFaturaMasraflari HalFaturaMasraflari { get; set; }
            public bool Use64BitService { get; set; }
            public bool TransactSupport { get; set; }
            public bool MuhasebelesmisBelge { get; set; }
            public int KalemAdedi { get; set; }
            public int FaturaTip { get; set; }
            public bool SonNumaraYazilsin { get; set; }
            public bool OtoIskontoGetir { get; set; }
            public bool KosulluHesapla { get; set; }
            public int InternalObjectAddress { get; set; }
            public bool SeriliHesapla { get; set; }
            public bool FiyatSistemineGoreHesapla { get; set; }
            public bool StokKartinaGoreHesapla { get; set; }
            public bool OtoVadeGunGetir { get; set; }
            public bool OtomatikIslemTipiGetir { get; set; }
            public bool OtomatikOdemeKoduGetir { get; set; }
            public bool MaliyetTipineGoreHesapla { get; set; }
            public bool OtomatikCevrimYapilsin { get; set; }
            public bool KayitliNumaraOtomatikGuncellensin { get; set; }
            public string Siralama { get; set; }
            public bool EPostaGonderilsin { get; set; }
            public bool OtoNakliyeKatSayisiGetir { get; set; }
            public bool OtoBolgeFarkIskGetir { get; set; }
            public bool RiskKontrol { get; set; }
            public int TahsilatKalemAdedi { get; set; }
            public bool TahsilatKayitKullan { get; set; }
            public bool AcikBelgeTahsilat { get; set; }
            public bool BaglantiKontrol { get; set; }
            public bool FaturaOtvTevkifatHesaplansin { get; set; }
            public bool YuklemeGunuHesapla { get; set; }
            public List<Kalem> Kalems { get; set; }
        }

        public class Kalem
        {
            public string DovizAdi { get; set; }
            public string STra_DovizAdi { get; set; }
            public List<object> KalemSeri { get; set; }
            public object Asorti { get; set; }
            public bool KosulMalFazlasiIsle { get; set; }
            public string StokKodu { get; set; }
            public int Sira { get; set; }
            public string STra_FATIRSNO { get; set; }
            public double STra_GCMIK { get; set; }
            public double STra_GCMIK2 { get; set; }
            public double CEVRIM { get; set; }
            public string STra_TAR { get; set; }
            public double STra_NF { get; set; }
            public double STra_BF { get; set; }
            public double STra_IAF { get; set; }
            public double STra_KDV { get; set; }
            public double STra_SatIsk { get; set; }
            public double STra_SatIsk2 { get; set; }
            public double STra_MALFISK { get; set; }
            public string STra_HTUR { get; set; }
            public int STra_DOVTIP { get; set; }
            public int PROMASYON_KODU { get; set; }
            public double STra_DOVFIAT { get; set; }
            public int STra_ODEGUN { get; set; }
            public string STra_KOD1 { get; set; }
            public string STra_KOD2 { get; set; }
            public string STra_SIP_TURU { get; set; }
            public string Ekalanneden { get; set; }
            public string Ekalan { get; set; }
            public double Stra_Otv { get; set; }
            public int Redneden { get; set; }
            public int STra_SIPKONT { get; set; }
            public int Firmadovtip { get; set; }
            public double Firmadovtut { get; set; }
            public double Firmadovmal { get; set; }
            public string Update_Kodu { get; set; }
            public int Ecza_fat_tip { get; set; }
            public int Olcubr { get; set; }
            public string Vadetar { get; set; }
            public int BaglantiNo { get; set; }
            public double BrCevrim1 { get; set; }
            public double BrCevrim2 { get; set; }
            public double Yed_Bf { get; set; }
            public string STra_BGTIP { get; set; }
            public string ReferansKodu { get; set; }
            public string C_Yedek6 { get; set; }
            public string STra_FTIRSIP { get; set; }
            public string STra_CARI_KOD { get; set; }
            public string STra_GC { get; set; }
            public int DEPO_KODU { get; set; }
            public int Gir_Depo_Kodu { get; set; }
            public string STra_ACIK { get; set; }
            public string Stra_OnayTipi { get; set; }
            public int Stra_OnayNum { get; set; }
            public int Stra_SubeKodu { get; set; }
            public int Stok_IsletmeKod { get; set; }
            public int Stok_SubeKod { get; set; }
            public int Stra_Exporttype { get; set; }
            public int IncKeyNo { get; set; }
            public int IncKeyNo2 { get; set; }
            public double TesMik { get; set; }
            public double TesMFMik { get; set; }
            public string MALADI { get; set; }
            public string STOK_GRKOD { get; set; }
            public int STMUHDKOD { get; set; }
            public double SONGIRBFIAT { get; set; }
            public string OBR1 { get; set; }
            public string OBR2 { get; set; }
            public string OBR3 { get; set; }
            public int SabitDepKod { get; set; }
            public int DOVTIP { get; set; }
            public int DOVIZ_TURU { get; set; }
            public double Fiyatlar1 { get; set; }
            public double Fiyatlar2 { get; set; }
            public double Fiyatlar3 { get; set; }
            public double Fiyatlar4 { get; set; }
            public double Fiyatlar5 { get; set; }
            public double Fiyatlar6 { get; set; }
            public double Fiyatlar7 { get; set; }
            public string Kilit { get; set; }
            public double SatisKDVOran { get; set; }
            public double AlisKDVOran { get; set; }
            public int Isk_Flag { get; set; }
            public int SipTesKont { get; set; }
            public string Mamulmu { get; set; }
            public string SeriTakibi { get; set; }
            public double Stra_Exportmik { get; set; }
            public double STra_SatIsk3 { get; set; }
            public double Kul_Mik { get; set; }
            public int Fiat_birimi { get; set; }
            public int Sat_IskTipleri1 { get; set; }
            public int Sat_IskTipleri2 { get; set; }
            public int Sat_IskTipleri3 { get; set; }
            public int Koli_Inc { get; set; }
            public bool KoliStok { get; set; }
            public string Tur { get; set; }
            public string Stra_FiiliTar { get; set; }
            public int BirimPuan { get; set; }
            public double PuanDeger { get; set; }
            public double KalemGenIskOran1 { get; set; }
            public double KalemGenIskOran2 { get; set; }
            public double KalemGenIskOran3 { get; set; }
            public int OtvFlag { get; set; }
            public double Otvtut { get; set; }
            public double STra_SatIsk4 { get; set; }
            public double STra_SatIsk5 { get; set; }
            public double STra_SatIsk6 { get; set; }
            public double KKMalF { get; set; }
            public int Stra_FiyatBirimi { get; set; }
            public int Stra_IrsKont { get; set; }
            public string SatisKilit { get; set; }
            public double Payda_1 { get; set; }
            public string D_YEDEK10 { get; set; }
            public int Sat_IskTipleri4 { get; set; }
            public int Sat_IskTipleri5 { get; set; }
            public int Sat_IskTipleri6 { get; set; }
            public bool EsnekMi { get; set; }
            public int SeriSayisi { get; set; }
            public double Stra_OTVFiat { get; set; }
            public double BolgeFark { get; set; }
            public double GEKAPTutar { get; set; }
            public double GEKAPAmbTutar { get; set; }
            public double KalemStopajOran { get; set; }
            public int SevkSubeDepo { get; set; }
            public string MusteriyeSevk { get; set; }
        }

        public class EIrsEkBilgi
        {
        }

        public class FatUst
        {
            public int Sube_Kodu { get; set; }
            public string CariKod { get; set; }
            public string FATIRS_NO { get; set; }
            public string Tarih { get; set; }
            public int Tip { get; set; }
            public string KOD1 { get; set; }
            public string YEDEK { get; set; }
            public string KOD2 { get; set; }
            public int TIPI { get; set; }
            public string Aciklama { get; set; }
            public double BRUTTUTAR { get; set; }
            public double KDV { get; set; }
            public double DovizTut { get; set; }
            public double SAT_ISKT { get; set; }
            public double GENELTOPLAM { get; set; }
            public double YUVARLAMA { get; set; }
            public double MFAZ_ISKT { get; set; }
            public double GEN_ISK1O { get; set; }
            public double GEN_ISK2O { get; set; }
            public double GEN_ISK3O { get; set; }
            public double FAT_ALTM1 { get; set; }
            public double FAT_ALTM2 { get; set; }
            public string KS_KODU { get; set; }
            public int ODEMEGUNU { get; set; }
            public string ODEMETARIHI { get; set; }
            public string ENTEGRE_TRH { get; set; }
            public bool KDV_DAHILMI { get; set; }
            public string SIPARIS_TEST { get; set; }
            public int SIRANO { get; set; }
            public int DOVIZTIP { get; set; }
            public int GENISK1TIP { get; set; }
            public int GENISK2TIP { get; set; }
            public int GENISK3TIP { get; set; }
            public int EXPORTTYPE { get; set; }
            public string EXFIILITARIH { get; set; }
            public int AMBHARTUR { get; set; }
            public string OnayTipi { get; set; }
            public int OnayNum { get; set; }
            public int GCKOD_GIRIS { get; set; }
            public int GCKOD_CIKIS { get; set; }
            public double GEN_ISK1T { get; set; }
            public double GEN_ISK2T { get; set; }
            public double GEN_ISK3T { get; set; }
            public int CikisYeri { get; set; }
            public int Degissin { get; set; }
            public int TopGirDepo { get; set; }
            public int TopDepo { get; set; }
            public string FiiliTarih { get; set; }
            public int KOSVADEGUNU { get; set; }
            public double BrMaliyet { get; set; }
            public double BOLGE_FARKI_ISK { get; set; }
            public double KDV1T { get; set; }
            public double KDV1O { get; set; }
            public double KDV2O { get; set; }
            public double KDV2T { get; set; }
            public double KDV3O { get; set; }
            public double KDV3T { get; set; }
            public double KDV4O { get; set; }
            public double KDV4T { get; set; }
            public double KDV5O { get; set; }
            public double KDV5T { get; set; }
            public bool EfaturaCarisiMi { get; set; }
            public int BaglantiNo { get; set; }
            public int EFatOzelKod { get; set; }
            public double OTV { get; set; }
            public bool EIrsaliye { get; set; }
            public int HalFaturasi { get; set; }
            public double FAT_ALTM3 { get; set; }
            public string DovBazTarihi { get; set; }
            public double OTVTevTutar { get; set; }
            public bool Konaklama { get; set; }
        }

        public class HalFaturaMasraflari
        {
        }

        private static DataTable set_usp_ketencekMrp_plc_data_N(string product_id,
            string product_code, string fatirs_no, int hours_pallet_count, DateTime entegre_date, string desc, string invoice_type,
            string group_code, string kod2, string warehouse_code, string stock_type, string stock_olcu_br1, string ref_code,
            string ambhartur, string cari_code, DateTime data_date, string topic)
        {
            DataTable table = new DataTable();
            try
            {
                using (var con = new SqlConnection("server=" + server + ";database=" + database + ";user=" + uid + ";password=" + password + ";"))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    using (var cmd = new SqlCommand("usp_ketencekMrp_plc_data_N", con))
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@product_id", product_id).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@product_code", product_code).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@fatirs_no", fatirs_no).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@hours_pallet_count", hours_pallet_count).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@entegre_date", entegre_date).SqlDbType = SqlDbType.DateTime;
                        cmd.Parameters.AddWithValue("@description", desc).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@invoice_type", invoice_type).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@group_code", group_code).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@kod2", kod2).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@warehouse_code", warehouse_code).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@stock_type", stock_type).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@stock_olcu_br1", stock_olcu_br1).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@ref_code", ref_code).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@ambhartur", ambhartur).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@cari_code", cari_code).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@data_date", data_date).SqlDbType = SqlDbType.DateTime;
                        cmd.Parameters.AddWithValue("@topic", topic).SqlDbType = SqlDbType.NChar;

                        da.Fill(table);
                    }
                }

                return table;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "");
                return table;
            }
        }

        public void onDebug()
        {
            OnStart(null);
        }
    }
}
