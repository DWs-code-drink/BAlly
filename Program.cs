using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace SKBetAlly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.GetCultureInfo("ja-JP");
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("ja-JP");
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("ja-JP");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ja-JP");
            Stopwatch sw = new Stopwatch();
            sw.Start();


            /*
            int[] Gl;
            byte[] als;
            double[][] SOCO;
            GauDesc.GauBA.GauResCoordRead(out Gl, out als, out SOCO);
            Console.WriteLine("\r\n");
            double rs = 0.0;
            double Vol;
            ParallelOptions po = new ParallelOptions();
            po.MaxDegreeOfParallelism = CommonParam.thdn;
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken ct = cts.Token;
            po.CancellationToken = ct;
            po.TaskScheduler = TaskScheduler.Default;
            Vol = GauDesc.GauBA.VolBS(SOCO, als, in Gl, 8, 1.4 * Math.Sqrt(3.0), ref po);
            Console.WriteLine(Vol);
            Console.WriteLine("\r\n");
            */



            //模型.Mba1D();
            //模型.Mba2D_20();
            //模型.Mba2D_26();
            //模型.Mba2D_26_9();
            //模型.Mba2D_8();
            //模型.Mba2D_22();
            //模型.Mba2D_29();
            //模型.Mba2D_37();
            //模型.Mba2D_3();
            //模型.Mba2D_39();
            //模型.Mba3D_3_20();
            //模型.Mba3D_8_22();
            //模型.Mba3D_8_16();
            //模型.Mba3D_8_26();
            //模型.Mba3D_20_21();
            //模型.Mba3D_20_25();
            //模型.Mba3D_20_39();
            //模型.Mba3D_8_20();
            //模型.Mba3D_20_27();
            //模型.Mba3D_22_34();
            //模型.Mba3D_20_26();
            //模型.Mba3D_20_29();
            //模型.Mba3D_3_22();
            //模型.Mba3D_22_39();
            //模型.Mba4D_8_20_26();
            //模型.Mba4D_8_22_26();
            //模型.Mba4D_20_22_39();
            //模型.Mba4D_8_26_35();
            //模型.Mba4D_8_22_34();
            //模型.Mba4D_12_22_34();
            //模型.Mba4D_22_27_34();
            //模型.Mba4D_3_22_34();
            //模型.MbaV3D(new int[3] { 4, 4, 4 }, new int[3] { 6, 20, 39 });
            //模型.MbaV3D(new int[3] { 4, 4, 4 }, new int[3] { 8, 22, 34 });
            //模型.MbaV3D(new int[3] { 4, 9, 4 }, new int[3] { 8, 9, 22 });
            //模型.MbaV3D(new int[3] { 4, 4, 4 }, new int[3] { 9, 20, 21 });
            //模型.MbaV3D(new int[3] { 4, 9, 4 }, new int[3] { 9, 20, 27 });
            //模型.MbaV3D(new int[3] { 4, 4, 4 }, new int[3] { 12, 22, 34 });
            //模型.MbaV3D(new int[3] { 4, 4, 4 }, new int[3] { 12, 22, 39 });
            //模型.MbaV3D(new int[3] { 4, 4, 4 }, new int[3] { 20, 22, 39 });
            //模型.MbaV3D(new int[3] { 4, 4, 4 }, new int[3] { 20, 21, 25 });
            //模型.MbaV3D(new int[3] { 4, 4, 4 }, new int[3] { 20, 21, 39 });
            //模型.MbaV3D(new int[3] { 4, 4, 9 }, new int[3] { 8, 22, 23 });
            //模型.MbaV3D(new int[3] { 4, 4, 4 }, new int[3] { 22, 25, 34 });
            //模型.MbaV3D(new int[3] { 4, 4, 4 }, new int[3] { 22, 25, 39 });
            //模型.MbaV3D(new int[3] { 4, 4, 9 }, new int[3] { 22, 25, 26 });
            //模型.MbaV3D(new int[3] { 4, 4, 4 }, new int[3] { 20, 26, 39 });
            //模型.MbaV3D(new int[3] { 4, 4, 4 }, new int[3] { 3, 20, 27 });
            //模型.MbaV3D(new int[3] { 4, 4, 4 }, new int[3] { 3, 22, 27 });
            //模型.MbaV3D(new int[3] { 4, 4, 4 }, new int[3] { 22, 27, 34 });
            //模型.MbaV3D(new int[3] { 4, 4, 4 }, new int[3] { 22, 27, 39 });
            //模型.MbaV3D(new int[3] { 4, 4, 4 }, new int[3] { 22, 33, 39 });
            //模型.MbaV3D(new int[3] { 4, 4, 9 }, new int[3] { 8, 22, 34 });
            //模型.MbaV3D(new int[3] { 4, 4, 4 }, new int[3] { 8, 22, 38 });
            //模型.MbaV3D(new int[3] { 4, 4, 4 }, new int[3] { 20, 21, 39 });
            //模型.MbaV3D(new int[3] { 4, 4, 4 }, new int[3] { 20, 25, 39 });
            //模型.MbaV3D(new int[3] { 4, 4, 4 }, new int[3] { 20, 26, 39 });
            //模型.MbaV4D(new int[4] { 4, 4, 9, 9 }, new int[4] { 8, 9, 22, 26 });
            //模型.MbaV4D(new int[4] { 4, 9, 4, 9 }, new int[4] { 8, 22, 25, 26 });
            //模型.MbaV4D(new int[4] { 4, 9, 9, 4 }, new int[4] { 20, 22, 26, 39 });
            //模型.MbaV4D(new int[4] { 4, 9, 9, 4 }, new int[4] { 20, 22, 32, 39 });
            //模型.MbaV4D(new int[4] { 4, 9, 9, 4 }, new int[4] { 8, 22, 26, 34 });
            //模型.MbaV4D(new int[4] { 4, 4, 4, 4 }, new int[4] { 8, 22, 27, 34 });
            //模型.MbaV4D(new int[4] { 4, 4, 4, 4 }, new int[4] { 8, 22, 25, 34 });
            //模型.MbaV4D(new int[4] { 4, 4, 4, 4 }, new int[4] { 8, 12, 22, 34 });
            //模型.MbaV4D(new int[4] { 4, 4, 4, 4 }, new int[4] { 5, 12, 22, 34 });
            //模型.MbaV4D(new int[4] { 4, 4, 4, 4 }, new int[4] { 12, 22, 27, 34 });
            //模型.MbaV4D(new int[4] { 4, 4, 4, 4 }, new int[4] { 12, 22, 34, 39 });
            //模型.MbaV4D(new int[4] { 4, 4, 4, 4 }, new int[4] { 3, 22, 27, 34 });
            //模型.MbaV4D(new int[4] { 4, 4, 4, 4 }, new int[4] { 9, 22, 27, 34 });
            //模型.MbaV4D(new int[4] { 4, 4, 4, 4 }, new int[4] { 22, 27, 34, 39 });
            //模型.MbaV4D(new int[4] { 4, 4, 4, 4 }, new int[4] { 3, 20, 22, 34 });
            //模型.MbaV4D(new int[4] { 4, 4, 4, 4 }, new int[4] { 3, 22, 25, 34 });




            //模型.EMtP();
            //模型.EMvP();



            //Console.WriteLine(SGKC.Exl2610.DtA0(20));



            /*
            string msg;
            DirectoryInfo di = new DirectoryInfo("D:\\ML\\OYTamn\\EV\\");
            THLogRgr.stage8(in di);
            Console.WriteLine();
            //*/



            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalMinutes);
            Console.WriteLine("AllByteCT={0}MB\tAllByte={1}MB\r\nTotMem={2}MB", (double)GC.GetAllocatedBytesForCurrentThread() / 1000000, (double)GC.GetTotalAllocatedBytes() / 1000000, (double)GC.GetTotalMemory(true) / 1000000);
        }
    }
    static internal class 模型
    {
        static readonly private string ナゾナゾ記述子 = "D:\\ML\\BAlly\\Data\\D1.csv";
        static readonly private string 乱数です = "D:\\ML\\BAlly\\Data\\Res.csv";
        static internal void Mba1D()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[1];
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                hs[0] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D1D\\{0}.THLRlog", cnt2));
                desin = new double[1][] { Des[cnt] };
                dind = new int[1] { cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[0] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D1D\\{0}.THLRlog", cnt2));
                desin = new double[1][] { Des[cnt] };
                dind = new int[1] { cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[0] = 4;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D1D\\{0}.THLRlog", cnt2));
                desin = new double[1][] { Des[cnt] };
                dind = new int[1] { cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[0] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D1D\\{0}.THLRlog", cnt2));
                desin = new double[1][] { Des[cnt] };
                dind = new int[1] { cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba2D_20()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 20)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_20\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[20], Des[cnt] };
                    dind = new int[2] { 20, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_20\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[20], Des[cnt] };
                dind = new int[2] { 20, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_20\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[20], Des[cnt] };
                dind = new int[2] { 20, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_20\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[20], Des[cnt] };
                dind = new int[2] { 20, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba2D_26()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 26)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_26\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[26], Des[cnt] };
                    dind = new int[2] { 26, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_26\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[26], Des[cnt] };
                dind = new int[2] { 26, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_26\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[26], Des[cnt] };
                dind = new int[2] { 26, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_26\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[26], Des[cnt] };
                dind = new int[2] { 26, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba2D_26_9()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 9;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 26)
                {
                    hs[1] = 9;
                    fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_26_9\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[26], Des[cnt] };
                    dind = new int[2] { 26, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_26_9\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[26], Des[cnt] };
                dind = new int[2] { 26, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 4;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_26_9\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[26], Des[cnt] };
                dind = new int[2] { 26, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_26_9\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[26], Des[cnt] };
                dind = new int[2] { 26, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba2D_8()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 8)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_8\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[8], Des[cnt] };
                    dind = new int[2] { 8, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_8\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[8], Des[cnt] };
                dind = new int[2] { 8, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_8\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[8], Des[cnt] };
                dind = new int[2] { 8, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_8\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[8], Des[cnt] };
                dind = new int[2] { 8, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba2D_22()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 22)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_22\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[22], Des[cnt] };
                    dind = new int[2] { 22, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_22\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[22], Des[cnt] };
                dind = new int[2] { 22, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_22\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[22], Des[cnt] };
                dind = new int[2] { 22, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_22\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[22], Des[cnt] };
                dind = new int[2] { 22, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba2D_29()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 29)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_29\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[29], Des[cnt] };
                    dind = new int[2] { 29, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_29\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[29], Des[cnt] };
                dind = new int[2] { 29, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_29\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[29], Des[cnt] };
                dind = new int[2] { 29, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_29\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[29], Des[cnt] };
                dind = new int[2] { 29, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba2D_37()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 37)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_37\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[37], Des[cnt] };
                    dind = new int[2] { 37, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_37\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[37], Des[cnt] };
                dind = new int[2] { 37, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_37\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[37], Des[cnt] };
                dind = new int[2] { 37, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_37\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[37], Des[cnt] };
                dind = new int[2] { 37, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba2D_3()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 3)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_3\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[3], Des[cnt] };
                    dind = new int[2] { 3, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_3\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[3], Des[cnt] };
                dind = new int[2] { 3, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_3\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[3], Des[cnt] };
                dind = new int[2] { 3, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_3\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[3], Des[cnt] };
                dind = new int[2] { 3, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba2D_39()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 39)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_39\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[39], Des[cnt] };
                    dind = new int[2] { 39, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_39\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[39], Des[cnt] };
                dind = new int[2] { 39, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_39\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[39], Des[cnt] };
                dind = new int[2] { 39, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_39\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[39], Des[cnt] };
                dind = new int[2] { 39, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba2D_20_9()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 9;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 20)
                {
                    hs[1] = 9;
                    fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_20_9\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[20], Des[cnt] };
                    dind = new int[2] { 20, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_20_9\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[20], Des[cnt] };
                dind = new int[2] { 20, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 4;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_20_9\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[20], Des[cnt] };
                dind = new int[2] { 20, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\BAlly\\D2D_20_9\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[20], Des[cnt] };
                dind = new int[2] { 20, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba3D_3_20()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\BAlly\\D3D_3(4)20(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[3], Des[20], Des[cnt] };
                dind = new int[3] { 3, 20, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 3 && cnt != 20)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba3D_8_22()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\BAlly\\D3D_8(4)22(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[8], Des[22], Des[cnt] };
                dind = new int[3] { 8, 22, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 8 && cnt != 22)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba3D_8_16()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\BAlly\\D3D_8(4)16(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[8], Des[16], Des[cnt] };
                dind = new int[3] { 8, 16, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 8 && cnt != 16)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba3D_8_26()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 9;
            fpth = "D:\\ML\\BAlly\\D3D_8(4)26(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[8], Des[26], Des[cnt] };
                dind = new int[3] { 8, 26, cnt };
                if (cnt != 26)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 8)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba3D_20_21()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\BAlly\\D3D_20(4)21(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[20], Des[21], Des[cnt] };
                dind = new int[3] { 20, 21, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 20 && cnt != 21)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba3D_20_25()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\BAlly\\D3D_20(4)25(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[20], Des[25], Des[cnt] };
                dind = new int[3] { 20, 25, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 20 && cnt != 25)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba3D_20_39()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\BAlly\\D3D_20(4)39(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[20], Des[39], Des[cnt] };
                dind = new int[3] { 20, 39, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 20 && cnt != 39)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba3D_8_20()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 9;
            fpth = "D:\\ML\\BAlly\\D3D_8(4)20(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[8], Des[20], Des[cnt] };
                dind = new int[3] { 8, 20, cnt };
                if (cnt != 20)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 8)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba3D_20_27()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 4;
            fpth = "D:\\ML\\BAlly\\D3D_20(9)27(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[20], Des[27], Des[cnt] };
                dind = new int[3] { 20, 27, cnt };
                if (cnt != 20)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 27)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba3D_22_34()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\BAlly\\D3D_22(4)34(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[22], Des[34], Des[cnt] };
                dind = new int[3] { 22, 34, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 22 && cnt != 34)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba3D_20_26()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\BAlly\\D3D_20(4)26(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[20], Des[26], Des[cnt] };
                dind = new int[3] { 20, 26, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 20 && cnt != 26)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba3D_20_29()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\BAlly\\D3D_20(4)29(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[20], Des[29], Des[cnt] };
                dind = new int[3] { 20, 29, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 20 && cnt != 29)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba3D_3_22()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\BAlly\\D3D_3(4)22(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[3], Des[22], Des[cnt] };
                dind = new int[3] { 3, 22, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 3 && cnt != 22)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba3D_22_39()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\BAlly\\D3D_22(4)39(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[22], Des[39], Des[cnt] };
                dind = new int[3] { 22, 39, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 22 && cnt != 39)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba4D_8_20_26()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 9;
            hs[2] = 9;
            fpth = "D:\\ML\\BAlly\\D4D_8(4)20(9)26(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[8], Des[20], Des[26], Des[cnt] };
                dind = new int[4] { 8, 20, 26, cnt };
                if (cnt != 20 && cnt != 26)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 8)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba4D_8_22_26()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 9;
            hs[2] = 9;
            fpth = "D:\\ML\\BAlly\\D4D_8(4)22(9)26(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[8], Des[22], Des[26], Des[cnt] };
                dind = new int[4] { 8, 22, 26, cnt };
                if (cnt != 22 && cnt != 26)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 8)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba4D_20_22_39()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 9;
            hs[2] = 4;
            fpth = "D:\\ML\\BAlly\\D4D_20(4)22(9)39(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[20], Des[22], Des[39], Des[cnt] };
                dind = new int[4] { 20, 22, 39, cnt };
                if (cnt != 22)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 20 && cnt != 39)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba4D_8_26_35()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 9;
            hs[2] = 4;
            fpth = "D:\\ML\\BAlly\\D4D_8(4)26(9)35(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[8], Des[26], Des[35], Des[cnt] };
                dind = new int[4] { 8, 26, 35, cnt };
                if (cnt != 26)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 8 && cnt != 35)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba4D_8_22_34()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\BAlly\\D4D_8(4)22(4)34(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[8], Des[22], Des[34], Des[cnt] };
                dind = new int[4] { 8, 22, 34, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 8 && cnt != 22 && cnt != 34)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba4D_12_22_34()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\BAlly\\D4D_12(4)22(4)34(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[12], Des[22], Des[34], Des[cnt] };
                dind = new int[4] { 12, 22, 34, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 12 && cnt != 22 && cnt != 34)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba4D_22_27_34()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\BAlly\\D4D_22(4)27(4)34(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[22], Des[27], Des[34], Des[cnt] };
                dind = new int[4] { 22, 27, 34, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 22 && cnt != 27 && cnt != 34)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void Mba4D_3_22_34()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\BAlly\\D4D_3(4)22(4)34(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[3], Des[22], Des[34], Des[cnt] };
                dind = new int[4] { 3, 22, 34, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 3 && cnt != 22 && cnt != 34)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }


















        static internal void MbaV3D(in int[] hs, in int[] d)
        {
            int GSK = 34340;
            int[] dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            if (!flg)
            {
                Console.WriteLine("Can not read the result file.");
            }
            fpth = string.Format("D:\\ML\\BAlly\\V\\{0}({1}){2}({3}){4}({5})\\", d[0], hs[0], d[1], hs[1], d[2], hs[2]);
            DirectoryInfo di = new DirectoryInfo(fpth);
            if (!di.Exists) di = Directory.CreateDirectory(fpth);
            desin = new double[3][] { Des[d[0]], Des[d[1]], Des[d[2]] };
            dind = new int[3] { d[0], d[1], d[2] };
            flg = THLogRgr.stage7(out msg, Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, in CT, in di);
            if (!flg) Console.WriteLine(msg);
        }
        static internal void MbaV4D(in int[] hs, in int[] d)
        {
            int GSK = 34340;
            int[] dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            if (!flg)
            {
                Console.WriteLine("Can not read the result file.");
            }
            fpth = string.Format("D:\\ML\\BAlly\\V\\{0}({1}){2}({3}){4}({5}){6}({7})\\", d[0], hs[0], d[1], hs[1], d[2], hs[2], d[3], hs[3]);
            DirectoryInfo di = new DirectoryInfo(fpth);
            if (!di.Exists) di = Directory.CreateDirectory(fpth);
            desin = new double[4][] { Des[d[0]], Des[d[1]], Des[d[2]], Des[d[3]] };
            dind = new int[4] { d[0], d[1], d[2], d[3] };
            flg = THLogRgr.stage7(out msg, Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, in CT, in di);
            if (!flg) Console.WriteLine(msg);
        }
        static internal void EMtP()
        {
            string msg;
            FileInfo df = new FileInfo("D:\\ML\\OYTamn\\EM\\tD\\Des_Ac1.csv");
            DirectoryInfo di = new DirectoryInfo("D:\\ML\\OYTamn\\EM\\");
            THLogRgr.stage10(out msg, in df, in di);
            Console.WriteLine(msg);
        }
        static internal void EMvP()
        {
            string msg;
            FileInfo df = new FileInfo("D:\\ML\\OYTamn\\EM\\pD\\DPAc1.csv");
            DirectoryInfo di = new DirectoryInfo("D:\\ML\\OYTamn\\EM\\");
            THLogRgr.stage10(out msg, in df, in di);
            Console.WriteLine(msg);
        }
    }
}