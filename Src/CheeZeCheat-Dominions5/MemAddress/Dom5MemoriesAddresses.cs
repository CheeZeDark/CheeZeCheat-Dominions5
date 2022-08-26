using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memory;

namespace Dom5.Addresses
{
    public class Dom5MemoriesAddresses
    {
        public string Player1FirePerlAddress = "0x25D73D2";
        public string Player1AirPerlAddress = "0x25D73D4";
        public string Player1WaterPerlAddress = "0x25D73D6";
        public string Player1EarthPerlAddress = "0x25D73D8";
        public string Player1DeathPerlAddress = "0x25D73DC";
        public string Player1NaturePerlAddress = "0x25D73DE";
        public string Player1BloodSlavesAddress = "0x25D73E0";
        public string Player2FirePerlAddress = "0x25D7C0E";
        public string Player2AirPerlAddress = "0x25D7C10";
        public string Player2WaterPerlAddress = "0x25D7C12";
        public string Player2EarthPerlAddress = "0x25D7C14";
        public string Player2DeathPerlAddress = "0x25D7C18";
        public string Player2NaturePerlAddress = "0x25D7C1A";
        public string Player2BloodSlavesAddress = "0x25D7C1C";
        public string Player3FirePerlAddress = "0x25D844A";
        public string Player3AirPerlAddress = "0x25D844C";
        public string Player3WaterPerlAddress = "0x25D844E";
        public string Player3EarthPerlAddress = "0x25D8450";
        public string Player3DeathPerlAddress = "0x25D8454";
        public string Player3NaturePerlAddress = "0x25D8456";
        public string Player3BloodSlavesAddress = "0x25D8458";
        public string Player4FirePerlAddress = "0x25D8C86";
        public string Player4AirPerlAddress = "0x25D8C88";
        public string Player4WaterPerlAddress = "0x25D8C8A";
        public string Player4EarthPerlAddress = "0x25D8C8C";
        public string Player4DeathPerlAddress = "0x25D8C90";
        public string Player4NaturePerlAddress = "0x25D8C92";
        public string Player4BloodSlavesAddress = "0x25D8C94";
    }
    public class Dom5StringNameProc
    {
        public string gameproc = "Dominions5.exe";
    }

    public class PerlsHack
    {
        // Classes for Initialization Address :D
        public Mem memskal = new Mem();
        public Dom5MemoriesAddresses mem = new Dom5MemoriesAddresses();
        public Dom5StringNameProc name_proc = new Dom5StringNameProc();
        public void ReadOtherPerlsPlr1()
        {
            memskal.OpenProcess("Dominions5");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player1FirePerlAddress}");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player1AirPerlAddress}");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player1WaterPerlAddress}");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player1EarthPerlAddress}");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player1DeathPerlAddress}");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player1NaturePerlAddress}");
        }
        public void WriteOtherPerlsPlr1(string numbers)
        {
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player1FirePerlAddress}", "int", numbers);
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player1AirPerlAddress}", "int", numbers);
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player1WaterPerlAddress}", "int", numbers);
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player1EarthPerlAddress}", "int", numbers);
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player1DeathPerlAddress}", "int", numbers);
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player1NaturePerlAddress}", "int", numbers);
        }
        public void ReadBloodSlavesPlr1()
        {
            memskal.OpenProcess("Dominions5");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player1BloodSlavesAddress}");
        }
        public void WriteBloodSlavesPlr1(string numbers)
        {
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player1BloodSlavesAddress}", "int", numbers);
        }
        public void ReadOtherPerlsPlr2()
        {
            memskal.OpenProcess("Dominions5");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player2FirePerlAddress}");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player2AirPerlAddress}");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player2WaterPerlAddress}");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player2EarthPerlAddress}");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player2DeathPerlAddress}");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player2NaturePerlAddress}");
        }
        public void WriteOtherPerlsPlr2(string numbers)
        {
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player2FirePerlAddress}", "int", numbers);
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player2AirPerlAddress}", "int", numbers);
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player2WaterPerlAddress}", "int", numbers);
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player2EarthPerlAddress}", "int", numbers);
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player2DeathPerlAddress}", "int", numbers);
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player2NaturePerlAddress}", "int", numbers);
        }
        public void ReadBloodSlavesPlr2()
        {
            memskal.OpenProcess("Dominions5");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player2BloodSlavesAddress}");
        }
        public void WriteBloodSlavesPlr2(string numbers)
        {
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player2BloodSlavesAddress}", "int", numbers);
        }
        public void ReadOtherPerlsPlr3()
        {
            memskal.OpenProcess("Dominions5");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player3FirePerlAddress}");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player3AirPerlAddress}");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player3WaterPerlAddress}");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player3EarthPerlAddress}");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player3DeathPerlAddress}");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player3NaturePerlAddress}");
        }
        public void WriteOtherPerlsPlr3(string numbers)
        {
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player3FirePerlAddress}", "int", numbers);
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player3AirPerlAddress}", "int", numbers);
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player3WaterPerlAddress}", "int", numbers);
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player3EarthPerlAddress}", "int", numbers);
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player3DeathPerlAddress}", "int", numbers);
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player3NaturePerlAddress}", "int", numbers);
        }
        public void ReadBloodSlavesPlr3()
        {
            memskal.OpenProcess("Dominions5");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player3BloodSlavesAddress}");
        }
        public void WriteBloodSlavesPlr3(string numbers)
        {
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player3BloodSlavesAddress}", "int", numbers);
        }
        public void ReadOtherPerlsPlr4()
        {
            memskal.OpenProcess("Dominions5");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player4FirePerlAddress}");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player4AirPerlAddress}");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player4WaterPerlAddress}");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player4EarthPerlAddress}");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player4DeathPerlAddress}");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player4NaturePerlAddress}");
        }
        public void WriteOtherPerlsPlr4(string numbers)
        {
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player4FirePerlAddress}", "int", numbers);
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player4AirPerlAddress}", "int", numbers);
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player4WaterPerlAddress}", "int", numbers);
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player4EarthPerlAddress}", "int", numbers);
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player4DeathPerlAddress}", "int", numbers);
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player4NaturePerlAddress}", "int", numbers);
        }
        public void ReadBloodSlavesPlr4()
        {
            memskal.OpenProcess("Dominions5");
            memskal.Read2Byte($"{name_proc.gameproc}+{mem.Player3BloodSlavesAddress}");
        }
        public void WriteBloodSlavesPlr4(string numbers)
        {
            memskal.WriteMemory($"{name_proc.gameproc}+{mem.Player4BloodSlavesAddress}", "int", numbers);
        }
    }
    public class GoldHackDominions5
    {
        public Mem mem_x = new Mem();
        public Dom5StringNameProc stringproc = new Dom5StringNameProc();
        public string GoldAmountPlayer1 = "0x25D73C0";
        public string GoldAmountPlayer2 = "0x25D7BFC";
        public string GoldAmountPlayer3 = "0x25D8438";
        public string GoldAmountPlayer4 = "0x25D8C74";
        public void ReadMemGoldPlr1()
        {
            mem_x.OpenProcess("Dominions5");
            mem_x.Read2Byte($"{stringproc.gameproc}+{GoldAmountPlayer1}");
        }
        public void WriteMemGoldPlr1(string numbers)
        {
            mem_x.WriteMemory($"{stringproc.gameproc}+{GoldAmountPlayer1}", "int", numbers);
        }
        public void ReadMemGoldPlr2()
        {
            mem_x.OpenProcess("Dominions5");
            mem_x.Read2Byte($"{stringproc.gameproc}+{GoldAmountPlayer2}");
        }
        public void WriteMemGoldPlr2(string numbers)
        {
            mem_x.WriteMemory($"{stringproc.gameproc}+{GoldAmountPlayer2}", "int", numbers);
        }
        public void ReadMemGoldPlr3()
        {
            mem_x.OpenProcess("Dominions5");
            mem_x.Read2Byte($"{stringproc.gameproc}+{GoldAmountPlayer3}");
        }
        public void WriteMemGoldPlr3(string numbers)
        {
            mem_x.WriteMemory($"{stringproc.gameproc}+{GoldAmountPlayer3}", "int", numbers);
        }
        public void ReadMemGoldPlr4()
        {
            mem_x.OpenProcess("Dominions5");
            mem_x.Read2Byte($"{stringproc.gameproc}+{GoldAmountPlayer4}");
        }
        public void WriteMemGoldPlr4(string numbers)
        {
            mem_x.WriteMemory($"{stringproc.gameproc}+{GoldAmountPlayer4}", "int", numbers);
        }
    }
}
