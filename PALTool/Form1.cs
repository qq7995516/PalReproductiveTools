using System.DirectoryServices;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace 幻兽帕鲁工具
{
    public partial class Form1 : Form
    {
        List<Pal> Pals = new List<Pal>();
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Pals.Add(new Pal() { Name = "皮皮鸡", ID = 3, Value = 1500, IndexOrder = 62 });
            Pals.Add(new Pal() { Name = "壶小象", ID = 16, Value = 1490, IndexOrder = 14 });
            Pals.Add(new Pal() { Name = "喵丝特", ID = 24, Value = 1480, IndexOrder = 4 });
            Pals.Add(new Pal() { Name = "棉悠悠", ID = 1, Value = 1470, IndexOrder = 27 });
            Pals.Add(new Pal() { Name = "捣蛋猫", ID = 2, Value = 1460, IndexOrder = 46 });
            Pals.Add(new Pal() { Name = "米露菲", ID = 18, Value = 1455, IndexOrder = 135 });
            Pals.Add(new Pal() { Name = "玉藻狐", ID = 14, Value = 1450, IndexOrder = 79 });
            Pals.Add(new Pal() { Name = "冰丝特", ID = 24, Value = 1440, IndexOrder = 5 });
            Pals.Add(new Pal() { Name = "翠叶鼠", ID = 4, Value = 1430, IndexOrder = 7 });
            Pals.Add(new Pal() { Name = "冰缚灵", ID = 32, Value = 1422, IndexOrder = 32 });
            Pals.Add(new Pal() { Name = "吊缚灵", ID = 32, Value = 1420, IndexOrder = 31 });
            Pals.Add(new Pal() { Name = "伏特喵", ID = 7, Value = 1410, IndexOrder = 65 });
            Pals.Add(new Pal() { Name = "融焰娘", ID = 70, Value = 1405, IndexOrder = 137 });
            Pals.Add(new Pal() { Name = "火绒狐", ID = 5, Value = 1400, IndexOrder = 20 });
            Pals.Add(new Pal() { Name = "啼卡尔", ID = 15, Value = 1390, IndexOrder = 82 });
            Pals.Add(new Pal() { Name = "瞅什魔", ID = 17, Value = 1380, IndexOrder = 47 });
            Pals.Add(new Pal() { Name = "电棘鼠", ID = 12, Value = 1370, IndexOrder = 17 });
            Pals.Add(new Pal() { Name = "冰刺鼠", ID = 12, Value = 1360, IndexOrder = 18 });
            Pals.Add(new Pal() { Name = "企丸丸", ID = 10, Value = 1350, IndexOrder = 23 });
            Pals.Add(new Pal() { Name = "炸蛋鸟", ID = 27, Value = 1340, IndexOrder = 8 });
            Pals.Add(new Pal() { Name = "冲浪鸭", ID = 6, Value = 1330, IndexOrder = 59 });
            Pals.Add(new Pal() { Name = "荆棘魔仙", ID = 30, Value = 1320, IndexOrder = 21 });
            Pals.Add(new Pal() { Name = "姬小兔", ID = 39, Value = 1310, IndexOrder = 117 });
            Pals.Add(new Pal() { Name = "毛掸儿", ID = 53, Value = 1300, IndexOrder = 114 });
            Pals.Add(new Pal() { Name = "勾魂鱿", ID = 23, Value = 1290, IndexOrder = 85 });
            Pals.Add(new Pal() { Name = "波娜兔", ID = 28, Value = 1280, IndexOrder = 91 });
            Pals.Add(new Pal() { Name = "火灵儿", ID = 81, Value = 1270, IndexOrder = 84 });
            Pals.Add(new Pal() { Name = "水灵儿", ID = 81, Value = 1260, IndexOrder = 83 });
            Pals.Add(new Pal() { Name = "新叶猿", ID = 8, Value = 1250, IndexOrder = 107 });
            Pals.Add(new Pal() { Name = "叶泥泥", ID = 13, Value = 1240, IndexOrder = 112 });
            Pals.Add(new Pal() { Name = "叶泥泥(特殊)", ID = 13, Value = 124, IndexOrder = 113 });
            Pals.Add(new Pal() { Name = "寐魔 ", ID = 19, Value = 1230, IndexOrder = 106 });
            Pals.Add(new Pal() { Name = "遁地鼠", ID = 22, Value = 1220, IndexOrder = 101 });
            Pals.Add(new Pal() { Name = "雷鸣童子", ID = 62, Value = 1210, IndexOrder = 24 });
            Pals.Add(new Pal() { Name = "棉花糖", ID = 34, Value = 1190, IndexOrder = 39 });
            Pals.Add(new Pal() { Name = "露娜蒂", ID = 21, Value = 1180, IndexOrder = 121 });
            Pals.Add(new Pal() { Name = "焰巫狐", ID = 76, Value = 1160, IndexOrder = 80 });
            Pals.Add(new Pal() { Name = "燎火鹿", ID = 9, Value = 1155, IndexOrder = 138 });
            Pals.Add(new Pal() { Name = "噬魂兽", ID = 66, Value = 1150, IndexOrder = 51 });
            Pals.Add(new Pal() { Name = "热血蜥", ID = 45, Value = 1140, IndexOrder = 58 });
            Pals.Add(new Pal() { Name = "草莽猪", ID = 20, Value = 1130, IndexOrder = 6 });
            Pals.Add(new Pal() { Name = "朋克蜥", ID = 45, Value = 1120, IndexOrder = 57 });
            Pals.Add(new Pal() { Name = "秘斯媞雅", ID = 63, Value = 1110, IndexOrder = 22 });
            Pals.Add(new Pal() { Name = "红小鲨", ID = 31, Value = 1100, IndexOrder = 26 });
            Pals.Add(new Pal() { Name = "鲨小子", ID = 31, Value = 1090, IndexOrder = 25 });
            Pals.Add(new Pal() { Name = "黑鸦隐士", ID = 44, Value = 1080, IndexOrder = 44 });
            Pals.Add(new Pal() { Name = "骑士蜂", ID = 50, Value = 1070, IndexOrder = 95 });
            Pals.Add(new Pal() { Name = "猎狼", ID = 26, Value = 1060, IndexOrder = 15 });
            Pals.Add(new Pal() { Name = "薇莉塔", ID = 78, Value = 1050, IndexOrder = 89 });
            Pals.Add(new Pal() { Name = "铁拳猿", ID = 49, Value = 1040, IndexOrder = 16 });
            Pals.Add(new Pal() { Name = "天擒鸟", ID = 47, Value = 1030, IndexOrder = 12 });
            Pals.Add(new Pal() { Name = "羽箭射手", ID = 48, Value = 1020, IndexOrder = 52 });
            Pals.Add(new Pal() { Name = "夜幕魔蝠", ID = 94, Value = 1010, IndexOrder = 70 });
            Pals.Add(new Pal() { Name = "山岳射手", ID = 48, Value = 1000, IndexOrder = 53 });
            Pals.Add(new Pal() { Name = "踏春兔", ID = 77, Value = 990, IndexOrder = 103 });
            Pals.Add(new Pal() { Name = "云海鹿", ID = 93, Value = 980, IndexOrder = 48 });
            Pals.Add(new Pal() { Name = "月镰魔", ID = 46, Value = 950, IndexOrder = 30 });
            Pals.Add(new Pal() { Name = "博爱蜥", ID = 69, Value = 940, IndexOrder = 81 });
            Pals.Add(new Pal() { Name = "灌木羊", ID = 35, Value = 930, IndexOrder = 75 });
            Pals.Add(new Pal() { Name = "紫霞鹿", ID = 37, Value = 920, IndexOrder = 9 });
            Pals.Add(new Pal() { Name = "波霸牛", ID = 29, Value = 910, IndexOrder = 86 });
            Pals.Add(new Pal() { Name = "祇岳鹿", ID = 37, Value = 900, IndexOrder = 10 });
            Pals.Add(new Pal() { Name = "趴趴鲶", ID = 43, Value = 895, IndexOrder = 136 });
            Pals.Add(new Pal() { Name = "美露帕", ID = 36, Value = 890, IndexOrder = 41 });
            Pals.Add(new Pal() { Name = "严冬鹿", ID = 59, Value = 880, IndexOrder = 76 });
            Pals.Add(new Pal() { Name = "鲁米儿", ID = 25, Value = 870, IndexOrder = 128 });
            Pals.Add(new Pal() { Name = "连理龙", ID = 86, Value = 860, IndexOrder = 71 });
            Pals.Add(new Pal() { Name = "碎岩龟", ID = 67, Value = 850, IndexOrder = 11 });
            Pals.Add(new Pal() { Name = "海誓龙", ID = 86, Value = 840, IndexOrder = 72 });
            Pals.Add(new Pal() { Name = "苍焰狼", ID = 61, Value = 830, IndexOrder = 56 });
            Pals.Add(new Pal() { Name = "花冠龙", ID = 64, Value = 820, IndexOrder = 63 });
            Pals.Add(new Pal() { Name = "雷冠龙", ID = 64, Value = 810, IndexOrder = 64 });
            Pals.Add(new Pal() { Name = "疾旋鼬", ID = 55, Value = 800, IndexOrder = 123 });
            Pals.Add(new Pal() { Name = "炽焰牛", ID = 42, Value = 790, IndexOrder = 99 });
            Pals.Add(new Pal() { Name = "花丽娜", ID = 87, Value = 780, IndexOrder = 130 });
            Pals.Add(new Pal() { Name = "吹雪狐", ID = 57, Value = 760, IndexOrder = 104 });
            Pals.Add(new Pal() { Name = "猫蝠怪", ID = 68, Value = 750, IndexOrder = 96 });
            Pals.Add(new Pal() { Name = "霹雳犬", ID = 60, Value = 740, IndexOrder = 100 });
            Pals.Add(new Pal() { Name = "狱焰王", ID = 84, Value = 710, IndexOrder = 108 });
            Pals.Add(new Pal() { Name = "暗巫猫", ID = 75, Value = 700, IndexOrder = 116 });
            Pals.Add(new Pal() { Name = "雷角马", ID = 56, Value = 680, IndexOrder = 19 });
            Pals.Add(new Pal() { Name = "狱阎王", ID = 84, Value = 670, IndexOrder = 109 });
            Pals.Add(new Pal() { Name = "烽歌龙", ID = 71, Value = 660, IndexOrder = 60 });
            Pals.Add(new Pal() { Name = "浪刃武士", ID = 72, Value = 640, IndexOrder = 127 });
            Pals.Add(new Pal() { Name = "霜歌龙", ID = 71, Value = 620, IndexOrder = 61 });
            Pals.Add(new Pal() { Name = "炎魔羊", ID = 40, Value = 590, IndexOrder = 2 });
            Pals.Add(new Pal() { Name = "暗魔羊", ID = 40, Value = 580, IndexOrder = 3 });
            Pals.Add(new Pal() { Name = "阿努比斯", ID = 100, Value = 570, IndexOrder = 1 });
            Pals.Add(new Pal() { Name = "滑水蛇", ID = 65, Value = 560, IndexOrder = 42 });
            Pals.Add(new Pal() { Name = "流沙蛇", ID = 65, Value = 550, IndexOrder = 43 });
            Pals.Add(new Pal() { Name = "精灵龙", ID = 80, Value = 540, IndexOrder = 37 });
            Pals.Add(new Pal() { Name = "水灵龙", ID = 80, Value = 530, IndexOrder = 38 });
            Pals.Add(new Pal() { Name = "企丸王", ID = 11, Value = 520, IndexOrder = 122 });
            Pals.Add(new Pal() { Name = "笑魇猫", ID = 52, Value = 510, IndexOrder = 131 });
            Pals.Add(new Pal() { Name = "碧海龙", ID = 82, Value = 500, IndexOrder = 45 });
            Pals.Add(new Pal() { Name = "幻悦蝶", ID = 41, Value = 490, IndexOrder = 132 });
            Pals.Add(new Pal() { Name = "绿苔绒怪", ID = 91, Value = 480, IndexOrder = 88 });
            Pals.Add(new Pal() { Name = "君王美露帕", ID = 89, Value = 470, IndexOrder = 110 });
            Pals.Add(new Pal() { Name = "白绒雪怪", ID = 91, Value = 460, IndexOrder = 87 });
            Pals.Add(new Pal() { Name = "绸笠蛾", ID = 79, Value = 450, IndexOrder = 78 });
            Pals.Add(new Pal() { Name = "冰帝美露帕", ID = 89, Value = 440, IndexOrder = 111 });
            Pals.Add(new Pal() { Name = "叶胖达", ID = 33, Value = 430, IndexOrder = 97 });
            Pals.Add(new Pal() { Name = "疾风隼", ID = 38, Value = 420, IndexOrder = 90 });
            Pals.Add(new Pal() { Name = "毛老爹", ID = 54, Value = 410, IndexOrder = 115 });
            Pals.Add(new Pal() { Name = "雷胖达", ID = 33, Value = 390, IndexOrder = 98 });
            Pals.Add(new Pal() { Name = "燧火鸟", ID = 74, Value = 380, IndexOrder = 126 });
            Pals.Add(new Pal() { Name = "荷鲁斯", ID = 105, Value = 370, IndexOrder = 73 });
            Pals.Add(new Pal() { Name = "火麒麟", ID = 58, Value = 360, IndexOrder = 35 });
            Pals.Add(new Pal() { Name = "天羽龙", ID = 95, Value = 350, IndexOrder = 124 });
            Pals.Add(new Pal() { Name = "铠格力斯", ID = 92, Value = 340, IndexOrder = 119 });
            Pals.Add(new Pal() { Name = "女皇蜂", ID = 51, Value = 330, IndexOrder = 94 });
            Pals.Add(new Pal() { Name = "熔岩兽", ID = 88, Value = 320, IndexOrder = 49 });
            Pals.Add(new Pal() { Name = "腾炎龙", ID = 101, Value = 315, IndexOrder = 29 });
            Pals.Add(new Pal() { Name = "覆海龙", ID = 101, Value = 310, IndexOrder = 28 });
            Pals.Add(new Pal() { Name = "森猛犸", ID = 90, Value = 300, IndexOrder = 68 });
            Pals.Add(new Pal() { Name = "雪猛犸", ID = 90, Value = 290, IndexOrder = 69 });
            Pals.Add(new Pal() { Name = "佩克龙", ID = 85, Value = 280, IndexOrder = 54 });
            Pals.Add(new Pal() { Name = "派克龙", ID = 85, Value = 270, IndexOrder = 55 });
            Pals.Add(new Pal() { Name = "冥铠蝎", ID = 99, Value = 260, IndexOrder = 133 });
            Pals.Add(new Pal() { Name = "百合女王", ID = 104, Value = 250, IndexOrder = 92 });
            Pals.Add(new Pal() { Name = "邪麒麟", ID = 58, Value = 240, IndexOrder = 36 });
            Pals.Add(new Pal() { Name = "寒霜兽", ID = 88, Value = 230, IndexOrder = 50 });
            Pals.Add(new Pal() { Name = "迅雷鸟", ID = 73, Value = 220, IndexOrder = 118 });
            Pals.Add(new Pal() { Name = "黑月女王", ID = 104, Value = 210, IndexOrder = 93 });
            Pals.Add(new Pal() { Name = "暴电熊", ID = 103, Value = 200, IndexOrder = 13 });
            Pals.Add(new Pal() { Name = "雷冥鸟", ID = 97, Value = 190, IndexOrder = 125 });
            Pals.Add(new Pal() { Name = "魔渊龙", ID = 98, Value = 150, IndexOrder = 102 });
            Pals.Add(new Pal() { Name = "波鲁杰克斯", ID = 106, Value = 140, IndexOrder = 134 });
            Pals.Add(new Pal() { Name = "冰棘兽", ID = 83, Value = 130, IndexOrder = 40 });
            Pals.Add(new Pal() { Name = "唤冬兽", ID = 110, Value = 120, IndexOrder = 66 });
            Pals.Add(new Pal() { Name = "唤夜兽", ID = 110, Value = 100, IndexOrder = 67 });
            Pals.Add(new Pal() { Name = "空涡龙", ID = 111, Value = 90, IndexOrder = 105 });
            Pals.Add(new Pal() { Name = "圣光骑士", ID = 108, Value = 80, IndexOrder = 120 });
            Pals.Add(new Pal() { Name = "混沌骑士", ID = 109, Value = 70, IndexOrder = 129 });
            Pals.Add(new Pal() { Name = "异构格里芬", ID = 107, Value = 60, IndexOrder = 77 });
            Pals.Add(new Pal() { Name = "朱雀 ", ID = 102, Value = 50, IndexOrder = 33 });
            Pals.Add(new Pal() { Name = "清雀 ", ID = 102, Value = 30, IndexOrder = 34 });
            Pals.Add(new Pal() { Name = "焰煌 ", ID = 96, Value = 10, IndexOrder = 74 });
            //(1120+1130)/2=

            //Pals.OrderBy(p => p.Value).ToList().ForEach(p =>
            //{
            //    textBox4.Text += $"{p.Name}-{p.Value}\r\n";
            //});
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var p1 = textBox1.Text.SearchPal(Pals);
            var p2 = textBox2.Text.SearchPal(Pals);
            var p3 = textBox3.Text.SearchPal(Pals);
            if (p1 != null && p2 != null)
            {
                //得出子代
                textBox3.Text = GetBreedingResults(p1, p2).Name;
            }
            if (p1 != null && p3 != null)
            {
                //由a和c得出b
                textBox2.Text = GetCombinations(p3).Where(d => d.Key.Name == p1.Name).First().Value.Name;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var p1 = textBox1.Text.SearchPal(Pals);
            var p2 = textBox2.Text.SearchPal(Pals);
            var p3 = textBox3.Text.SearchPal(Pals);
            if (p1 != null && p2 != null)
            {
                //得出子代
                textBox3.Text = GetBreedingResults(p1, p2).Name;
            }
            if (p2 != null && p3 != null)
            {
                //由b和c得出a
                textBox1.Text = GetCombinations(p3).Where(d => d.Value.Name == p2.Name).First().Key.Name;
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var p = textBox3.Text.SearchPal(Pals);
            if (p != null)
            {
                //获取组合
                var keyValues = GetCombinations(p);
                keyValues.ForEach(d =>
                {
                    var o = new ListViewItem() { Text = d.Key.Name };
                    o.SubItems.Add(new ListViewItem.ListViewSubItem { Text = d.Value.Name });
                    o.SubItems.Add(new ListViewItem.ListViewSubItem { Text = p.Name });
                    listView1.Items.Add(o);
                });
            }

            var p1 = textBox1.Text.SearchPal(Pals);
            var p2 = textBox2.Text.SearchPal(Pals);
            var p3 = textBox3.Text.SearchPal(Pals);
            if (p1 != null && p3 != null)
                //由a和c得出b
                textBox2.Text = GetCombinations(p3).Where(d => d.Key.Name == p1.Name).First().Value.Name;
            if (p2 != null && p3 != null)
                //由b和c得出a
                textBox1.Text = GetCombinations(p3).Where(d => d.Value.Name == p2.Name).First().Key.Name;
        }

        /// <summary>
        /// 获取繁殖结果
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public Pal GetBreedingResults(Pal a, Pal b)
        {
            var res = (a.Value + b.Value) / 2;
            //繁殖力方差升序
            var Ps = Pals.OrderBy(p => Math.Abs(p.Value - res)).ToList();
            //挑选出方差和第一个相等的所有帕鲁
            var tmppl = Ps.Where(p => Math.Abs(p.Value - res) == Math.Abs(Ps[0].Value - res)).ToList();
            //IndexOrder升序,得到繁殖结果的帕鲁
            var p = tmppl.OrderBy(p => p.IndexOrder).ToList();
            return p.First();
        }

        /// <summary>
        /// 通过子代获取繁殖组合可能
        /// </summary>
        /// <param name="c">繁殖结果帕鲁</param>
        /// <returns></returns>
        public List<KeyValuePair<Pal, Pal>> GetCombinations(Pal c)
        {
            var pals = new List<KeyValuePair<Pal, Pal>>();
            //繁殖力公式:(a+b)/2=c

            Pals.ForEach(k =>
            {
                Pals.ForEach(v =>
                {
                    var tmpP = GetBreedingResults(k, v);
                    if (tmpP.Name == c.Name && pals.Where(d => d.Key.Name == v.Name && d.Value.Name == k.Name).Count() == 0)
                    {
                        pals.Add(new KeyValuePair<Pal, Pal>(k, v));
                    }
                });
            });
            return pals;
        }
    }

    public class Pal
    {
        public string Name { get; set; }
        public int ID { get; set; }
        /// <summary>
        /// 繁殖力
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// 未知值..
        /// </summary>
        public int IndexOrder { get; set; }
    }
}