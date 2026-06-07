using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;

namespace _cslt.session_09.exercise_10
{
    public static class CoBan
    {
        // Bai 1
        public static void GhiDaySo(string path, int n)
        {
            Random rnd = new Random();
            StreamWriter sw = new StreamWriter(path);
            for (int i = 0; i < n; i++) sw.WriteLine(rnd.Next(1, 101));
        }
        public static void InDaySo(string path)
        {
            if (!File.Exists(path)) return;
            string[] lines = File.ReadAllLines(path);
            Console.WriteLine(string.Join(", ", lines));
        }
        // Bai 2
        public static void SaoChepLoaiBoDongTrong(string srcPath, string destPath)
        {
            var validLines = File.ReadLines(srcPath).Where(line => !string.IsNullOrWhiteSpace(line));
            File.WriteAllLines(destPath, validLines);
        }
        // Bai 3
        public static void LocSoChanTrongFile(string inputPath, string outputPath)
        {
            var evenNumbers = File.ReadLines(inputPath)
                                  .Where(x => int.TryParse(x, out int n) && n % 2 == 0);
            File.WriteAllLines(outputPath, evenNumbers);
        }
        // Bai 4
        public static int DemTuKhoa(string path, string keyword)
        {
            string content = File.ReadAllText(path);
            return Regex.Matches(content, Regex.Escape(keyword), RegexOptions.IgnoreCase).Count;
        }
        // Bai 5
        public static void ChuyenDoiChuHoaThuong(string path, bool toUpper)
        {
            string content = File.ReadAllText(path);
            File.WriteAllText(path, toUpper ? content.ToUpper() : content.ToLower());
        }
        // Bai 6
        public static void ThayTheTuKhoa(string path, string oldWord, string newWord)
        {
            string content = File.ReadAllText(path);
            File.WriteAllText(path, content.Replace(oldWord, newWord));
        }
        // Bai 7
        public static void GhepHaiFile(string file1, string file2, string fileDich)
        {
            StreamWriter sw = new StreamWriter(fileDich);
            sw.Write(File.ReadAllText(file1));
            sw.Write(File.ReadAllText(file2));
        }
        // Bai 8
        public static void TimMinMaxTrongFile(string path, out int max, out int min)
        {
            var numbers = File.ReadLines(path).Select(int.Parse).ToList();
            max = numbers.Max();
            min = numbers.Min();
        }
        // Bai 9
        public static void DaoNguocCacDong(string inputPath, string outputPath)
        {
            var lines = File.ReadAllLines(inputPath).Reverse();
            File.WriteAllLines(outputPath, lines);
        }
        // Bai 10
        public static void TrichXuatDongDau(string srcPath, string destPath, int n)
        {
            var lines = File.ReadLines(srcPath).Take(n);
            File.WriteAllLines(destPath, lines);
        }
    }
    public static class TrungBinh
    {
        // Bai 11
        public static void TinhDiemTrungBinh(string inputPath, string outputPath)
        {
            var lines = File.ReadLines(inputPath);
            StreamWriter sw = new StreamWriter(outputPath);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                {
                    double toan = double.Parse(parts[1].Trim());
                    double van = double.Parse(parts[2].Trim());
                    double dtb = (toan + van) / 2;
                    sw.WriteLine($"{parts[0].Trim()} : {dtb:F1}");
                }
            }
        }
        // Bai 12
        public static int TinhTongMaTran(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int n = int.Parse(lines[0]);
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += lines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse).Sum();
            }
            return sum;
        }
        // Bai 13
        public static void TrichXuatLogLoi(string logPath, string errorOutputPath)
        {
            StreamReader sr = new StreamReader(logPath);
            StreamWriter sw = new StreamWriter(errorOutputPath);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains("[ERROR]") || line.Contains("[CRITICAL]"))
                    sw.WriteLine(line);
            }
        }
        // Bai 14
        public static void DanhSoThuTuDong(string path)
        {
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
                lines[i] = $"{(i + 1):D3}. {lines[i]}";
            File.WriteAllLines(path, lines);
        }
        // Bai 15
        public static void ChenDongVaoFile(string path, string noiDungChen, int viTriK)
        {
            List<string> lines = File.ReadAllLines(path).ToList();
            if (viTriK >= 1 && viTriK <= lines.Count + 1)
                lines.Insert(viTriK - 1, noiDungChen);
            File.WriteAllLines(path, lines);
        }
        // Bai 16
        public static void XoaDongTrongFile(string path, int viTriK)
        {
            List<string> lines = File.ReadAllLines(path).ToList();
            if (viTriK >= 1 && viTriK <= lines.Count)
                lines.RemoveAt(viTriK - 1);
            File.WriteAllLines(path, lines);
        }
        // Bai 17
        public static void CapNhatConfig(string path, string key, string newValue)
        {
            var lines = File.ReadAllLines(path).ToList();
            bool found = false;
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].StartsWith(key + "="))
                {
                    lines[i] = $"{key}={newValue}";
                    found = true;
                    break;
                }
            }
            if (!found) lines.Add($"{key}={newValue}");
            File.WriteAllLines(path, lines);
        }
        // Bai 18   
        public static void MaHoaCaesarFile(string srcPath, string destPath, int shift)
        {
            string content = File.ReadAllText(srcPath);
            char[] buffer = content.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
                buffer[i] = (char)(buffer[i] + shift);
            File.WriteAllText(destPath, new string(buffer));
        }
        // Bai 19
        public static void TangLuongNhanVienCSV(string path, double phanTramTang)
        {
            var lines = File.ReadAllLines(path);
            for (int i = 1; i < lines.Length; i++) // Bỏ qua Header
            {
                var parts = lines[i].Split(',');
                if (parts.Length >= 3 && double.TryParse(parts[2], out double luong))
                {
                    luong += luong * (phanTramTang / 100);
                    parts[2] = luong.ToString();
                    lines[i] = string.Join(",", parts);
                }
            }
            File.WriteAllLines(path, lines);
        }
        // Bai 20
        public static bool KiemTraNgoacTrongFile(string codePath)
        {
            string code = File.ReadAllText(codePath);
            Stack<char> stack = new Stack<char>();
            foreach (char c in code)
            {
                if (c == '{' || c == '(') stack.Push(c);
                else if (c == '}' || c == ')')
                {
                    if (stack.Count == 0) return false;
                    char open = stack.Pop();
                    if ((c == '}' && open != '{') || (c == ')' && open != '(')) return false;
                }
            }
            return stack.Count == 0;
        }
    }
    public static class NangCao
    {
        // Bai 21
        public static void XorFileStream(string inputPath, string outputPath, byte key)
        {
            FileStream fsIn = new FileStream(inputPath, FileMode.Open, FileAccess.Read);
            FileStream fsOut = new FileStream(outputPath, FileMode.Create, FileAccess.Write);
            int b;
            while ((b = fsIn.ReadByte()) != -1)
                fsOut.WriteByte((byte)(b ^ key));
        }
        // Bai 22
        public static void CatFileNhiPhan(string srcPath, long kichThuocPhanDoan)
        {
            FileStream fs = new FileStream(srcPath, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[8192];
            int partNum = 1;
            while (fs.Position < fs.Length)
            {
                FileStream fsPart = new FileStream($"{srcPath}.part{partNum}", FileMode.Create);
                long bytesWritten = 0;
                int bytesRead;
                while (bytesWritten < kichThuocPhanDoan &&
                      (bytesRead = fs.Read(buffer, 0, (int)Math.Min(buffer.Length, kichThuocPhanDoan - bytesWritten))) > 0)
                {
                    fsPart.Write(buffer, 0, bytesRead);
                    bytesWritten += bytesRead;
                }
                partNum++;
            }
        }
        // Bai 23
        public static void GhepFilePhanDoan(string[] danhSachFilePart, string fileGocDest)
        {
            FileStream fsOut = new FileStream(fileGocDest, FileMode.Create, FileAccess.Write);
            foreach (string part in danhSachFilePart.OrderBy(x => x)) // Đảm bảo đúng thứ tự part1, part2...
            {
                FileStream fsIn = new FileStream(part, FileMode.Open, FileAccess.Read);
                fsIn.CopyTo(fsOut);
            }
        }
        // Bai 24
        public static void SaoChepFileLon(string src, string dest)
        {
            FileStream fsIn = new FileStream(src, FileMode.Open, FileAccess.Read);
            FileStream fsOut = new FileStream(dest, FileMode.Create, FileAccess.Write);
            byte[] buffer = new byte[8192];
            long totalBytes = fsIn.Length;
            long copiedBytes = 0;
            int read;

            while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
            {
                fsOut.Write(buffer, 0, read);
                copiedBytes += read;
                double percent = (double)copiedBytes / totalBytes * 100;
                Console.Write($"\rCopying: {percent:F2}%");
            }
            Console.WriteLine("\nDone!");
        }
        // Bai 25   
        public static List<string> DocLogCuoiFile(string path, int n)
        {
            List<string> lines = new List<string>();
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            if (fs.Length == 0) return lines;
            long pos = fs.Length - 1;
            StringBuilder currentLine = new StringBuilder();
            while (pos >= 0 && lines.Count < n)
            {
                fs.Seek(pos, SeekOrigin.Begin);
                char c = (char)fs.ReadByte();
                if (c == '\n')
                {
                    if (currentLine.Length > 0)
                    {
                        lines.Add(new string(currentLine.ToString().Reverse().ToArray()));
                        currentLine.Clear();
                    }
                }
                else if (c != '\r') currentLine.Append(c);
                pos--;
            }
            // Them dong dau tien nếu chua gap \n o dau file
            if (currentLine.Length > 0 && lines.Count < n)
                lines.Add(new string(currentLine.ToString().Reverse().ToArray()));
            lines.Reverse();
            return lines;
        }

        // Bai 26
        public static void TronHaiFileDaSapXep(string file1, string file2, string fileDich)
        {
            StreamReader sr1 = new StreamReader(file1);
            StreamReader sr2 = new StreamReader(file2);
            StreamWriter sw = new StreamWriter(fileDich);

            string line1 = sr1.ReadLine(), line2 = sr2.ReadLine();
            while (line1 != null || line2 != null)
            {
                if (line1 == null) { sw.WriteLine(line2); line2 = sr2.ReadLine(); }
                else if (line2 == null) { sw.WriteLine(line1); line1 = sr1.ReadLine(); }
                else
                {
                    int v1 = int.Parse(line1), v2 = int.Parse(line2);
                    if (v1 <= v2) { sw.WriteLine(v1); line1 = sr1.ReadLine(); }
                    else { sw.WriteLine(v2); line2 = sr2.ReadLine(); }
                }
            }
        }
        // Bai 27 (Su dung Generic <T> de ham co the nhan bat ky danh sach doi tuong nao)
        public static void LuuDanhSachJson<T>(string path, List<T> list)
        {
            string jsonString = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, jsonString);
        }
        public static List<T> DocDanhSachJson<T>(string path)
        {
            if (!File.Exists(path)) return new List<T>();
            string jsonString = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<T>>(jsonString);
        }
        // Bai 28
        private static readonly object _fileLock = new object();
        public static void GhiLogAnToan(string path, string message)
        {
            lock (_fileLock)
            {
                StreamWriter sw = new StreamWriter(path, true);
                sw.WriteLine($"[{DateTime.Now}] {message}");
            }
        }
        // Bai 29
        public static void NenGZipFile(string srcPath, string zipPath)
        {
            FileStream fsIn = new FileStream(srcPath, FileMode.Open, FileAccess.Read);
            FileStream fsOut = new FileStream(zipPath, FileMode.Create, FileAccess.Write);
            GZipStream gzStream = new GZipStream(fsOut, CompressionMode.Compress);
            fsIn.CopyTo(gzStream);
        }
        // Bai 30
        public static void DocThongTinNhacMp3(string mp3Path, out string title, out string artist)
        {
            title = "";
            artist = "";
            FileStream fs = new FileStream(mp3Path, FileMode.Open, FileAccess.Read);
            if (fs.Length < 128) return; // File quá nhỏ, không thể chứa thẻ ID3v1
            fs.Seek(-128, SeekOrigin.End);
            byte[] tagInfo = new byte[128];
            fs.Read(tagInfo, 0, 128);
            string tag = Encoding.ASCII.GetString(tagInfo, 0, 3);
            if (tag == "TAG")
            {
                title = Encoding.Default.GetString(tagInfo, 3, 30).Trim('\0', ' ');
                artist = Encoding.Default.GetString(tagInfo, 33, 30).Trim('\0', ' ');
            }
        }
    }
}