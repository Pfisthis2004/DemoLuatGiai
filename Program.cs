

namespace BT3
{
    public class BoiToanRecord
    {
        public string CauHoi { get; set; }
        public string LuaChonA { get; set; }
        public string LuaChonB { get; set; }
        public string LuaChonC { get; set; }
        public string LuaChonD { get; set; }
        public int LuaChonNguoiDung { get; set; }

        public BoiToanRecord(string cauHoi, string luaChonA, string luaChonB, string luaChonC, string luaChonD)
        {
            CauHoi = cauHoi;
            LuaChonA = luaChonA;
            LuaChonB = luaChonB;
            LuaChonC = luaChonC;
            LuaChonD = luaChonD;
            LuaChonNguoiDung = -1;
        }
    }

    public class Program
    {
        public static void Main()
        {
            List<BoiToanRecord> records = new List<BoiToanRecord>
            {
                new BoiToanRecord("Cau hoi 1: Ban co mot bua tiec vao cuoi tuan nay.",
                                  "A. Toi se to chuc tiec tai nha.",
                                  "B. Toi se di den mot bua tiec.",
                                  "C. Toi se khong tham gia tiec nao.",
                                  "D. Toi khong biet."),
                new BoiToanRecord("Cau hoi 2: Ban thich thoi tiet nhu the nao?",
                                  "A. Troi nang.",
                                  "B. Troi mat me.",
                                  "C. Troi mua.",
                                  "D. Troi lanh."),
                new BoiToanRecord("Cau hoi 3: Ban muon di dau trong ky nghi?",
                                  "A. Bien.",
                                  "B. Nui.",
                                  "C. Thanh pho.",
                                  "D. Noi khac."),
                new BoiToanRecord("Cau hoi 4: Ban thich xem loai phim nao?",
                                  "A. Hanh dong",
                                  "B. Hai huoc",
                                  "C. Kinh di",
                                  "D. Tinh cam"),
                new BoiToanRecord("Cau hoi 5: Ban thuong lam gi vao cuoi tuan?",
                                  "A. Di du lich",
                                  "B. Ngu va thu gian",
                                  "C. Hoc tap",
                                  "D. Gap go ban be"),
                new BoiToanRecord("Cau hoi 6: Ban thich loai nhac nao?",
                                  "A. Nhac pop",
                                  "B. Nhac rock",
                                  "C. Nhac co dien",
                                  "D. Nhac EDM"),
                new BoiToanRecord("Cau hoi 7: Ban co thoi quen nao khi lam viec khong?",
                                  "A. Nghe nhac",
                                  "B. Uong ca phe",
                                  "C. Khong co thoi quen",
                                  "D. Lam viec trong im lang"),
                new BoiToanRecord("Cau hoi 8: Ban muon lam viec trong linh vuc nao?",
                                  "A. Cong nghe",
                                  "B. Nghe thuat",
                                  "C. Kinh doanh",
                                  "D. Giao duc"),
                new BoiToanRecord("Cau hoi 9: Ban cam thay minh la nguoi nhu the nao trong mot nhom?",
                                  "A. Lanh dao",
                                  "B. Nguoi ho tro",
                                  "C. Quan sat",
                                  "D. Tham gia tich cuc"),
                new BoiToanRecord("Cau hoi 10: Ban thich doc loai sach nao?",
                                  "A. Tieu thuyet",
                                  "B. Sach phi hu cau",
                                  "C. Sach khoa hoc",
                                  "D. Sach tu giup"),
            };

            foreach (var record in records)
            {
                Console.WriteLine(record.CauHoi);
                Console.WriteLine($"A: {record.LuaChonA}");
                Console.WriteLine($"B: {record.LuaChonB}");
                Console.WriteLine($"C: {record.LuaChonC}");
                Console.WriteLine($"D: {record.LuaChonD}");
                Console.Write("Nhap lua chon (A/B/C/D): ");

                string luaChonNguoiDung = Console.ReadLine()?.ToUpper();
                switch (luaChonNguoiDung)
                {
                    case "A":
                        record.LuaChonNguoiDung = 0;
                        break;
                    case "B":
                        record.LuaChonNguoiDung = 1;
                        break;
                    case "C":
                        record.LuaChonNguoiDung = 2;
                        break;
                    case "D":
                        record.LuaChonNguoiDung = 3;
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le");
                        record.LuaChonNguoiDung = -1;
                        break;
                }

                Console.WriteLine("-----------------------------");
            }

            // Sử dụng luật giải để suy ra kết quả cuối cùng
            SuyRaKetQua(records);
        }

        public static void SuyRaKetQua(List<BoiToanRecord> records)
        {
            // Khai báo các biến cho từng lựa chọn
            bool m1A = false, m1B = false, m1C = false, m1D = false;
            bool m2A = false, m2B = false, m2C = false, m2D = false;
            bool m3A = false, m3B = false, m3C = false, m3D = false;
            bool m4A = false, m4B = false, m4C = false, m4D = false;
            bool m5A = false, m5B = false, m5C = false, m5D = false;
            bool m6A = false, m6B = false, m6C = false, m6D = false;
            bool m7A = false, m7B = false, m7C = false, m7D = false;
            bool m8A = false, m8B = false, m8C = false, m8D = false;
            bool m9A = false, m9B = false, m9C = false, m9D = false;
            bool m10A = false, m10B = false, m10C = false, m10D = false;

            foreach (var record in records)
            {
                if (record.LuaChonNguoiDung == 0) // A
                {
                    if (record.CauHoi.Contains("bua tiec")) m1A = true;
                    else if (record.CauHoi.Contains("thoi tiet")) m2A = true;
                    else if (record.CauHoi.Contains("ky nghi")) m3A = true;
                    else if (record.CauHoi.Contains("phim")) m4A = true;
                    else if (record.CauHoi.Contains("cuoi tuan")) m5A = true;
                    else if (record.CauHoi.Contains("nhac")) m6A = true;
                    else if (record.CauHoi.Contains("thoi quen")) m7A = true;
                    else if (record.CauHoi.Contains("linh vuc")) m8A = true;
                    else if (record.CauHoi.Contains("nhom")) m9A = true;
                    else if (record.CauHoi.Contains("sach")) m10A = true;
                }
                else if (record.LuaChonNguoiDung == 1) // B
                {
                    if (record.CauHoi.Contains("bua tiec")) m1B = true;
                    else if (record.CauHoi.Contains("thoi tiet")) m2B = true;
                    else if (record.CauHoi.Contains("ky nghi")) m3B = true;
                    else if (record.CauHoi.Contains("phim")) m4B = true;
                    else if (record.CauHoi.Contains("cuoi tuan")) m5B = true;
                    else if (record.CauHoi.Contains("nhac")) m6B = true;
                    else if (record.CauHoi.Contains("thoi quen")) m7B = true;
                    else if (record.CauHoi.Contains("linh vuc")) m8B = true;
                    else if (record.CauHoi.Contains("nhom")) m9B = true;
                    else if (record.CauHoi.Contains("sach")) m10B = true;
                }
                else if (record.LuaChonNguoiDung == 2) // C
                {
                    if (record.CauHoi.Contains("bua tiec")) m1C = true;
                    else if (record.CauHoi.Contains("thoi tiet")) m2C = true;
                    else if (record.CauHoi.Contains("ky nghi")) m3C = true;
                    else if (record.CauHoi.Contains("phim")) m4C = true;
                    else if (record.CauHoi.Contains("cuoi tuan")) m5C = true;
                    else if (record.CauHoi.Contains("nhac")) m6C = true;
                    else if (record.CauHoi.Contains("thoi quen")) m7C = true;
                    else if (record.CauHoi.Contains("linh vuc")) m8C = true;
                    else if (record.CauHoi.Contains("nhom")) m9C = true;
                    else if (record.CauHoi.Contains("sach")) m10C = true;
                }
                else if (record.LuaChonNguoiDung == 3) // D
                {
                    if (record.CauHoi.Contains("bua tiec")) m1D = true;
                    else if (record.CauHoi.Contains("thoi tiet")) m2D = true;
                    else if (record.CauHoi.Contains("ky nghi")) m3D = true;
                    else if (record.CauHoi.Contains("phim")) m4D = true;
                    else if (record.CauHoi.Contains("cuoi tuan")) m5D = true;
                    else if (record.CauHoi.Contains("nhac")) m6D = true;
                    else if (record.CauHoi.Contains("thoi quen")) m7D = true;
                    else if (record.CauHoi.Contains("linh vuc")) m8D = true;
                    else if (record.CauHoi.Contains("nhom")) m9D = true;
                    else if (record.CauHoi.Contains("sach")) m10D = true;
                }
            }

            // Áp dụng luật suy luận cho các kết luận
            // Kết luận 1: m1A ∨ m1B, ¬m1B ∨ m1C  ⇒ m   1A ∨ m1C
            if (m1A || m1B)
            {
                if (!m1B || m1C)
                {
                    Console.WriteLine("Ket luan: Ban co kha nang to chuc bua tiec hoac se tham gia bua tiec.");
                }
            }

            // Kết luận 2: m2A ∨ m2B, ¬m2B ∨ m2C  ⇒ m2A ∨ m2C
            else if (m2A || m2B)
            {
                if (!m2B || m2C)
                {
                    Console.WriteLine("Ket luan: Ban thich thoi tiet nang hoac mat me.");
                }
            }

            // Kết luận 3: m3A ∨ m3B, ¬m3B ∨ m3C  ⇒ m3A ∨ m3C
            else if (m3A || m3B)
            {
                if (!m3B || m3C)
                {
                    Console.WriteLine("Ket luan: Ban muon đi bien hoac đi nghi o noi khac.");
                }
            }

            // Kết luận 4: m4A ∨ m4B, ¬m4B ∨ m4C  ⇒ m4A ∨ m4C
            else if (m4A || m4B)
            {
                if (!m4B || m4C)
                {
                    Console.WriteLine("Ket luan: Ban thich phim hanh đong hoac khong thich phim kinh di.");
                }
            }

            // Kết luận 5: m5A ∨ m5B, ¬m5B ∨ m5C  ⇒ m5A ∨ m5C
            else if (m5A || m5B)
            {
                if (!m5B || m5C)
                {
                    Console.WriteLine("Ket luan: Ban thich đi du lich hoac thich thu gian vao cuoi tuan.");
                }
            }

            // Kết luận 6: m6A ∨ m6B, ¬m6B ∨ m6C  ⇒ m6A ∨ m6C
            else if (m6A || m6B)
            {
                if (!m6B || m6C)
                {
                    Console.WriteLine("Ket luan: Ban thich nhac pop hoac khong thich nhac co đien.");
                }
            }

            // Kết luận 7: m7A ∨ m7B, ¬m7B ∨ m7C  ⇒ m7A ∨ m7C
            else if (m7A || m7B)
            {
                if (!m7B || m7C)
                {
                    Console.WriteLine("Ket luan: Ban co thoi quen nghe nhac hoac thich lam viec trong im lang.");
                }
            }

            // Kết luận 8: m8A ∨ m8B, ¬m8B ∨ m8C  ⇒ m8A ∨ m8C
            else if (m8A || m8B)
            {
                if (!m8B || m8C)
                {
                    Console.WriteLine("Ket luan: Ban muon lam viec trong linh vuc cong nghe hoac khong thich lam viec trong nghe thuat.");
                }
            }

            // Kết luận 9: m9A ∨ m9B, ¬m9B ∨ m9C  ⇒ m9A ∨ m9C
            else if (m9A || m9B)
            {
                if (!m9B || m9C)
                {
                    Console.WriteLine("Ket luan: Ban cam thay minh la lanh đao hoặc quan sat trong mot nhom.");
                }
            }

            // Kết luận 10: m10A ∨ m10B, ¬m10B ∨ m10C  ⇒ m10A ∨ m10C
            else if (m10A || m10B)
            {
                if (!m10B || m10C)
                {
                    Console.WriteLine("Ket luan: Ban thich đoc tieu thuyet hoac sach phi hu cau.");
                }
            }
        }
    }
}

