using System.Text.RegularExpressions;

namespace SKBetAlly
{
    internal class DataRW
    {
        static private Regex rcsv = new Regex(@"^(?:(?>([^,]+)),?)+$", RegexOptions.Compiled, TimeSpan.FromSeconds(3.434));
        static internal bool ResR(in string fpth, out double[] yr, out double var)
        {
            yr = null;
            var = double.NaN;
            if (!File.Exists(fpth))
            {
                Console.WriteLine("Can not find result file.");
                return false;
            }
            string stemp;
            double dtemp;
            bool flg;
            List<double> dl = new List<double>();
            using (FileStream fs = new FileStream(fpth, FileMode.Open, FileAccess.Read, FileShare.None, 128))
            {
                using (StreamReader sr = new StreamReader(fs, true))
                {
                    do
                    {
                        stemp = sr.ReadLine();
                        flg = double.TryParse((stemp ?? string.Empty).Trim(), out dtemp);
                        if (!flg)
                        {
                            yr = dl.ToArray();
                            break;
                        }
                        else dl.Add(dtemp);
                    }
                    while (stemp != null);
                }
            }
            if (yr == null)
            {
                Console.WriteLine("Invalid result data.");
                return false;
            }
            else if (yr.Length <= 1)
            {
                Console.WriteLine("Invalid result data amount.");
                return false;
            }
            else
            {
                dtemp = 0.0;
                double atemp;
                var = 0.0;
                for (int cnt = 0; cnt < yr.Length; cnt++)
                {
                    dtemp += yr[cnt];
                }
                atemp = dtemp / yr.Length;
                for (int cnt = 0; cnt < yr.Length; cnt++)
                {
                    dtemp = yr[cnt] - atemp;
                    var += dtemp * dtemp;
                }
                var /= yr.Length;
            }
            return true;
        }
        static internal bool DesR(in string fpth, out double[][] desr)
        {
            desr = null;
            if (!File.Exists(fpth))
            {
                Console.WriteLine("Cna not find descriptor file.");
                return false;
            }
            string stemp;
            double dtemp;
            bool flg;
            List<double>[] destemp;
            Match m;
            int cnt, ivf = 0, ivf2 = 0;
            using (FileStream fs = new FileStream(fpth, FileMode.Open, FileAccess.Read, FileShare.None, 128))
            {
                using (StreamReader sr = new StreamReader(fs, true))
                {
                    stemp = sr.ReadLine();
                    m = rcsv.Match(stemp ?? string.Empty);
                    if (!m.Success)
                    {
                        Console.WriteLine("Invalid descriptor information.");
                        return false;
                    }
                    destemp = new List<double>[m.Groups[1].Captures.Count];
                    for (cnt = 0; cnt < m.Groups[1].Captures.Count;)
                    {
                        flg = double.TryParse(m.Groups[1].Captures[cnt].Value.Trim(), out dtemp);
                        if (!flg)
                        {
                            ivf2 = cnt;
                            Console.WriteLine("Warning : Can not verify descriptor amount, {0} read.", ivf2);
                            break;
                        }
                        destemp[cnt] = new List<double>();
                        destemp[cnt].Add(dtemp);
                        cnt++;
                        if (cnt == m.Groups[1].Captures.Count)
                        {
                            ivf2 = cnt;
                        }
                    }
                    if (ivf2 < 1)
                    {
                        Console.WriteLine("Invalid descriptors.");
                    }
                    else
                    {
                        ivf++;
                        do
                        {
                            stemp = sr.ReadLine();
                            m = rcsv.Match(stemp ?? string.Empty);
                            if (!m.Success)
                            {
                                break;
                            }
                            if (m.Groups[1].Captures.Count != ivf2)
                            {
                                Console.WriteLine("Can not verify descriptor amount, line {0}, {1} read.", ivf + 1, m.Groups[1].Captures.Count);
                            }
                            for (cnt = 0; cnt < ivf2; cnt++)
                            {
                                flg = double.TryParse(m.Groups[1].Captures[cnt].Value.Trim(), out dtemp);
                                if (!flg)
                                {
                                    Console.WriteLine("Invalid line ({0}), {1} read.", ivf + 1, cnt + 1);
                                    return false;
                                }
                                destemp[cnt].Add(dtemp);
                            }
                            ivf++;
                        }
                        while (stemp != null);
                    }
                }
            }
            desr = new double[ivf2][];
            for (cnt = 0; cnt < desr.Length; cnt++)
            {
                desr[cnt] = destemp[cnt].ToArray();
                if (desr[cnt].Length != ivf)
                {
                    Console.WriteLine("Can not verify data amount of descriptor {0}.", cnt + 1);
                    return false;
                }
            }
            return true;
        }
    }
}
