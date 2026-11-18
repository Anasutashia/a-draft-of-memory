using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Черновик_памяти
{
    public partial class Form3 : Form

    {
        private List<Question> allquestions;
        private List<Question> questions;
        private List<Question> questions1;
        private List<Question> questions2;
        private List<Question> questions3;
        private List<Question> questions4;
        private List<Question> questions5;
        private List<Question> questions6;
        private List<Question> questions7;
        private List<Question> questions8;
        private List<Question> questions9;
        private List<Question> questions10;
        private List<Question> questions11;
        private List<Question> questions12;
        private List<Question> questions13;
        private List<Question> questions14;
        private List<Question> questions15;
        private List<Question> questions16;
        private List<Question> questions17;
        private List<Question> questions18;
        private List<Question> questions19;
        private List<Question> questions20;
        private List<Question> questions21;
        private List<Question> questions22;
        private List<Question> questions23;
        private List<Question> questions24;
        private List<Question> questions25;
        private List<Question> questions26;
        private List<Question> questions27;
        private List<Question> questions28;
        private List<Question> questions29;
        private List<Question> questions30;
        private List<Question> questions31;
        private List<Question> questions32;
        private List<Question> questions33;
        private List<Question> questions34;
        private List<Question> questions35;
        private List<Question> questions36;
        private List<Question> questions37;

        private int currentQuestionIndex = 0;
        private int score = 0;
        private Button[] buttons;
        
        private Form2 _mainForm = null;
        public Form3(Form2 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            if (MdiParent is Form1_roditel parent)
            {
                var existingForm2 = parent.MdiChildren.OfType<Form2>().FirstOrDefault();
                if (existingForm2 == null)
                {
                    MessageBox.Show("проёбана форма с деревом", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            buttons = new Button[] { button1, button2, button3, button4 };
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Tag = i; // Сохраняем номер кнопки в Tag
                buttons[i].Click += Button_Button_Click; // Подписываем на общее событие
            }
            InitQuestions();
            DisplayQuestion();
        }
        private void InitQuestions()
        {
            allquestions = new List<Question>();

            
            questions1 = new List<Question> { 
            // ===== ДОМ И КВАРТИРА =====
            new Question( "дом, здание fángzi(фанцзы)", "房子"),
            new Question( "дом, семья jiā(цзя)", "家"),
            new Question( "квартира gōngyù(гунъюй)", "公寓"),
            new Question( "комната fángjiān(фанцзянь)", "房间"),
            new Question( "дверь mén(мэнь)", "门"),
            new Question( "окно chuānghu(чуанху)", "窗户"),
            new Question( "стена qiáng(цян)", "墙"),
            new Question( "пол dìbǎn(дибань)", "地板"),
            new Question( "потолок tiānhuābǎn(тяньхуабань)", "天花板"),
            new Question( "крыша wūdǐng(удин)", "屋顶"),
            new Question( "лестница lóutī(лоути)", "楼梯"),
            new Question( "лифт diàntī(дяньти)", "电梯"),
            new Question( "подвал dìxiàshì(дисяши)", "地下室"),
            new Question( "балкон yángtái(янтай)", "阳台"),
            new Question( "мебель jiājù(цзяцзюй)", "家具"),
            new Question( "кровать chuáng(чуан)", "床"),
            new Question( "стол zhuōzi(чжоцзы)", "桌子"),
            new Question( "стул yǐzi(ицзы)", "椅子"),
            new Question( "диван shāfā(шафа)", "沙发"),
            new Question( "шкаф для одежды yīguì(игуй)", "衣柜"),
            new Question( "книжная полка shūjià(шуцзя)", "书架"),
            new Question( "лампа, свет dēng(дэн)", "灯"),
            new Question( "зеркало jìngzi(цзинцзы)", "镜子"),
            new Question( "ковёр dìtǎn(дитань)", "地毯"),
            new Question( "шторы chuānglián(чуанлянь)", "窗帘"),
            new Question( "обои qiángzhǐ(цянчжи)", "墙纸"),
            new Question( "ключ yàoshi(яоши)", "钥匙"),
            new Question( "замок suǒ(со)", "锁"),
            };
               questions2 = new List<Question> {             
               // ===== ЖИВОТНЫЕ =====
               new Question( "собака gǒu(гоу)", "狗"),
               new Question( "кошка māo(мао)", "猫"),
               new Question( "птица niǎo(няо)", "鸟"),
               new Question( "рыба yú(юй)", "鱼"),
               new Question( "лошадь mǎ(ма)", "马"),
               new Question( "корова, бык niú(ню)", "牛"),
               new Question( "овца, коза yáng(ян)", "羊"),
               new Question( "свинья zhū(чжу)", "猪"),
               new Question( "курица, петух jī(цзи)", "鸡"),
               new Question( "утка yā(я)", "鸭"),
               new Question( "гусь é(э)", "鹅"),
               new Question( "кролик tùzi(туцзы)", "兔子"),
               new Question( "мышь, крыса lǎoshǔ(лаошу)", "老鼠"),
               new Question( "тигр lǎohǔ(лаоху)", "老虎"),
               new Question( "лев shīzi(шицзы)", "狮子"),
               new Question( "медведь xióng(сюн)", "熊"),
               new Question( "волк láng(лан)", "狼"),
               new Question( "лиса húli(хули)", "狐狸"),
               new Question( "змея shé(шэ)", "蛇"),
               new Question( "дракон lóng(лун)", "龙"),
               new Question( "феникс fènghuáng(фэнхуан)", "凤凰"),
               new Question( "журавль hè(хэ)", "鹤"),
               new Question( "бабочка húdié(худе)", "蝴蝶"),

               };
               questions3 = new List<Question> {
               new Question( "еда, рис fàn(фань)", "饭"),
                new Question( "блюдо, овощи cài(цай)", "菜"),
                new Question( "мясо ròu(жоу)", "肉"),
                new Question( "говядина niúròu(нюжоу)", "牛肉"),
                new Question( "свинина zhūròu(чжужоу)", "猪肉"),
                new Question( "курица (мясо) jīròu(цзижоу)", "鸡肉"),
                new Question( "рыба yú(юй)", "鱼"),
                new Question( "креветка xiā(ся)", "虾"),
                new Question( "яйцо dàn(дань)", "蛋"),
                new Question( "тофу dòufu(доуфу)", "豆腐"),
                new Question( "лапша miàntiáo(мяньтяо)", "面条"),
                new Question( "рис (варёный) mǐfàn(мифань)", "米饭"),
                new Question( "суп tāng(тан)", "汤"),
                new Question( "паровой пирожок bāozi(баоцзы)", "包子"),
                new Question( "пельмени jiǎozi(цзяоцзы)", "饺子"),
                new Question( "хлеб miànbāo(мяньбао)", "面包"),
                new Question( "фрукты shuǐguǒ(шуйго)", "水果"),
                new Question( "яблоко píngguǒ(пинго)", "苹果"),
                new Question( "виноград pútao(путао)", "葡萄"),
                new Question( "арбуз xīguā(сигуа)", "西瓜"),
                new Question( "чай chá(ча)", "茶"),
                new Question( "кофе kāfēi(кафэй)", "咖啡"),
                new Question( "алкоголь, вино jiǔ(цзю)", "酒"),
                new Question( "вода shuǐ(шуй)", "水"),
                new Question( "молоко niúnǎi(нюнай)", "牛奶"),
                new Question( "сок guǒzhī(гочжи)", "果汁"),
                new Question( "сахар táng(тан)", "糖"),
                new Question( "соль yán(янь)", "盐"),
                new Question( "уксус cù(цу)", "醋"),
                new Question( "соевый соус jiàngyóu(цзянъю)", "酱油"),
                new Question( "перец чили làjiāo(лацзяо)", "辣椒"),

               };

               questions4 = new List<Question> {             
               // ===== ЦВЕТА =====
                new Question( "красный hóng(хун)", "红"),
                new Question( "оранжевый chéng(чэн)", "橙"),
                new Question( "жёлтый huáng(хуан)", "黄"),
                new Question( "зелёный lǜ(люй)", "绿"),
                new Question( "сине-зелёный, голубой qīng(цин)", "青"),
                new Question( "синий lán(лань)", "蓝"),
                new Question( "фиолетовый zǐ(цзы)", "紫"),
                new Question( "чёрный hēi(хэй)", "黑"),
                new Question( "белый bái(бай)", "白"),
                new Question( "серый huī(хуэй)", "灰"),
                new Question( "розовый fěn(фэнь)", "粉"),
                new Question( "серебряный yín(инь)", "银"),
                new Question( "золотой jīn(цзинь)", "金"),
                new Question( "коричневый zōng(цзун)", "棕"),
                new Question( "кофейный kāfēisè(кафэйсэ)", "咖啡色"),

               };
               questions5 = new List<Question>
               {
                 // ===== ОДЕЖДА =====
                new Question( "одежда yīfu(ифу)", "衣服"),
                new Question( "штаны, брюки kùzi(куцзы)", "裤子"),
                new Question( "юбка, платье qúnzi(цюньцзы)", "裙子"),
                new Question( "рубашка chènshān(чэньшань)", "衬衫"),
                new Question( "пальто, куртка wàitào(вайтао)", "外套"),
                new Question( "пальто dàyī(даи)", "大衣"),
                new Question( "свитер máoyī(маои)", "毛衣"),
                new Question( "обувь xiézi(сецзы)", "鞋子"),
                new Question( "носки wàzi(вацзы)", "袜子"),
                new Question( "шапка, шляпа màozi(маоцзы)", "帽子"),
                new Question( "шарф wéijīn(вэйцзинь)", "围巾"),
                new Question( "перчатки shǒutào(шоутао)", "手套"),
                new Question( "пояс, ремень yāodài(яодай)", "腰带"),
                new Question( "галстук lǐngdài(линдай)", "领带"),
                new Question( "пуговица niǔkòu(нюкоу)", "纽扣"),
                new Question( "карман kǒudài(коудай)", "口袋"),
                new Question( "рукав xiùzi(сюцзы)", "袖子"),
                new Question( "нижнее бельё nèiyī(нэйи)", "内衣"),
                new Question( "пижама shuìyī(шуйи)", "睡衣"),
                new Question( "форма, униформа zhìfú(чжифу)", "制服"),
                new Question( "доспехи kuījiǎ(куйцзя)", "盔甲"),
                new Question( "лёгкие доспехи qīngkǎi(цинкай)", "轻铠"),
                new Question( "длинный халат chángpáo(чанпао)", "长袍"),
                new Question( "плащ, накидка dǒupéng(доупэн)", "斗篷"),
                new Question( "вуаль miànshā(мяньша)", "面纱"),

               };
               questions6 = new List<Question>
               {
                  // ===== ТРАНСПОРТ =====
                new Question( "машина, повозка chē(чэ)", "车"),
                new Question( "автомобиль qìchē(цичэ)", "汽车"),
                new Question( "автобус gōngjiāochē(гунцзяочэ)", "公交车"),
                new Question( "такси chūzūchē(чуцзучэ)", "出租车"),
                new Question( "поезд huǒchē(хочэ)", "火车"),
                new Question( "метро dìtiě(дите)", "地铁"),
                new Question( "самолёт fēijī(фэйцзи)", "飞机"),
                new Question( "лодка, корабль chuán(чуань)", "船"),
                new Question( "велосипед zìxíngchē(цзысинчэ)", "自行车"),
                new Question( "мотоцикл mótuōchē(мотуочэ)", "摩托车"),
                new Question( "лошадь mǎ(ма)", "马"),
                new Question( "повозка mǎchē(мачэ)", "马车"),
                new Question( "паланкин jiàozi(цзяоцзы)", "轿子"),
                new Question( "меч jiàn(цзянь)", "剑"),
                new Question( "летающий меч fēijiàn(фэйцзянь)", "飞剑"),
                new Question( "дорога lù(лу)", "路"),
                new Question( "мост qiáo(цяо)", "桥"),
                new Question( "станция chēzhàn(чэчжань)", "车站"),
                new Question( "аэропорт jīchǎng(цзичан)", "机场"),
                new Question( "пристань mǎtóu(матоу)", "码头"),

               };
               questions7 = new List<Question>
               {
                  // ===== ПРОФЕССИИ =====
                new Question( "учитель lǎoshī(лаоши)", "老师"),
                new Question( "наставник shīfu(шифу)", "师父"),
                new Question( "почтенный учитель shīzūn(шицзунь)", "师尊"),
                new Question( "ученик xuéshēng(сюэшэн)", "学生"),
                new Question( "врач yīshēng(ишэн)", "医生"),
                new Question( "медсестра hùshi(хуши)", "护士"),
                new Question( "торговец shāngrén(шанжэнь)", "商人"),
                new Question( "хозяин лавки zhǎngguì(чжангуй)", "掌柜"),
                new Question( "крестьянин nóngmín(нунминь)", "农民"),
                new Question( "рабочий gōngrén(гунжэнь)", "工人"),
                new Question( "солдат shìbīng(шибин)", "士兵"),
                new Question( "генерал jiāngjūn(цзянцзюнь)", "将军"),             
                new Question( "глава школы zhǎngmén(чжанмэнь)", "掌门"),
                new Question( "ученик dìzǐ(дицзы)", "弟子"),
                new Question( "старейшина zhǎnglǎo(чжанлао)", "长老"),
                new Question( "даос dàoshi(даоши)", "道士"),
                new Question( "буддийский монах héshang(хэшан)", "和尚"),
                new Question( "учёный, студент shūshēng(шушэн)", "书生"),
                new Question( "художник huàjiā(хуацзя)", "画家"),
                new Question( "поэт shīrén(шижэнь)", "诗人"),
                new Question( "музыкант qínshī(циньши)", "琴师"),
                new Question( "повар chúshī(чушы)", "厨师"),
                new Question( "портной cáifeng(цайфэн)", "裁缝"),
                new Question( "кузнец tiějiàng(тецзян)", "铁匠"),

               };
               questions8 = new List<Question>
               {
                  // ===== ЧАСТИ ТЕЛА =====
                new Question( "тело shēntǐ(шэньти)", "身体"),
                new Question( "голова tóu(тоу)", "头"),
                new Question( "волосы tóufa(тоуфа)", "头发"),
                new Question( "лицо liǎn(лянь)", "脸"),
                new Question( "глаза yǎnjing(яньцзин)", "眼睛"),
                new Question( "брови méimao(мэймао)", "眉毛"),
                new Question( "нос bízi(бицзы)", "鼻子"),
                new Question( "рот zuǐ(цзуй)", "嘴"),
                new Question( "губы zuǐchún(цзуйчунь)", "嘴唇"),
                new Question( "зубы yáchǐ(ячи)", "牙齿"),
                new Question( "язык shétou(шэтоу)", "舌头"),
                new Question( "уши ěrduo(эрдо)", "耳朵"),
                new Question( "шея bózi(боцзы)", "脖子"),
                new Question( "плечи jiānbǎng(цзяньбан)", "肩膀"),
                new Question( "руки (от плеча) gēbo(гэбо)", "胳膊"),
                new Question( "рука (кисть) shǒu(шоу)", "手"),
                new Question( "пальцы shǒuzhǐ(шоучжи)", "手指"),
                new Question( "грудь xiōngkǒu(сюнкоу)", "胸口"),
                new Question( "спина bèi(бэй)", "背"),
                new Question( "поясница, талия yāo(яо)", "腰"),
                new Question( "живот dùzi(дуцзы)", "肚子"),
                new Question( "ноги tuǐ(туй)", "腿"),
                new Question( "ступня jiǎo(цзяо)", "脚"),
                new Question( "сердце (орган) xīnzàng(синьцзан)", "心脏"),
                new Question( "кровь xuè(сюэ)", "血"),
                new Question( "кости gǔtou(гутоу)", "骨头"),
                new Question( "кожа pífū(пифу)", "皮肤"),

               };
               questions9 = new List<Question>
               {
                  // ===== ЭМОЦИИ =====
                new Question( "любить ài(ай)", "爱"),
                new Question( "ненавидеть hèn(хэнь)", "恨"),
                new Question( "нравиться xǐhuān(сихуань)", "喜欢"),
                new Question( "не нравиться tǎoyàn(таоень)", "讨厌"),
                new Question( "радостный kāixīn(кайсинь)", "开心"),
                new Question( "грустный nánguò(наньго)", "难过"),
                new Question( "злиться shēngqì(шэнцы)", "生气"),
                new Question( "бояться hàipà(хайпа)", "害怕"),
                new Question( "беспокоиться dānxīn(даньсинь)", "担心"),
                new Question( "одинокий gūdú(гуду)", "孤独"),
                new Question( "печальный bēishāng(бэйшан)", "悲伤"),
                new Question( "страдание tòngkǔ(тунку)", "痛苦"),
                new Question( "гнев fènnù(фэнну)", "愤怒"),
                new Question( "удивление jīngyà(цзинъя)", "惊讶"),
                new Question( "нервничать jǐnzhāng(цзиньчжан)", "紧张"),
                new Question( "разочарование shīwàng(шиван)", "失望"),
                new Question( "отчаяние juéwàng(цзюэван)", "绝望"),
                new Question( "завидовать jídù(цзиду)", "嫉妒"),
                new Question( "сочувствие tóngqíng(тунцин)", "同情"),
                new Question( "быть тронутым gǎndòng(гундун)", "感动"),
                new Question( "довольный mǎnyì(маньи)", "满意"),
                new Question( "сожалеть hòuhuǐ(хоухуэй)", "后悔"),
                new Question( "беспомощность wúnài(унай)", "无奈"),
                new Question( "болеть сердцем xīnténg(синьтэн)", "心疼"),
                new Question( "обида и ненависть yuànhèn(юаньхэнь)", "怨恨"),
                new Question( "слепая любовь chīqíng(чицин)", "痴情"),
                new Question( "мягкосердечный xīnruǎn(синьжуань)", "心软"),
                new Question( "жестокосердный xīnhěn(синьхэнь)", "心狠"),

               };
               questions10 = new List<Question>
               {
                   // ===== ПОГОДА =====
                new Question( "погода tiānqì(тяньци)", "天气"),
                new Question( "ясный qíng(цин)", "晴"),
                new Question( "пасмурный yīn(инь)", "阴"),
                new Question( "дождь yǔ(юй)", "雨"),
                new Question( "снег xuě(сюэ)", "雪"),
                new Question( "ветер fēng(фэн)", "风"),
                new Question( "облако yún(юнь)", "云"),
                new Question( "туман wù(у)", "雾"),
                new Question( "гром léi(лэй)", "雷"),
                new Question( "молния shǎndiàn(шаньдянь)", "闪电"),
                new Question( "радуга cǎihóng(цайхун)", "彩虹"),
                new Question( "лёд bīng(бин)", "冰"),
                new Question( "иней shuāng(шуан)", "霜"),
                new Question( "роса lùshuǐ(лушуй)", "露水"),
                new Question( "солнце tàiyáng(тайян)", "太阳"),
                new Question( "луна yuèliang(юэлян)", "月亮"),
                new Question( "звёзды xīngxing(синсин)", "星星"),
                new Question( "небо tiānkōng(тянькун)", "天空"),
                new Question( "температура wēndù(вэньду)", "温度"),
                new Question( "жарко rè(жэ)", "热"),
                new Question( "холодно lěng(лэн)", "冷"),
                new Question( "тепло nuǎnhuo(нуаньхо)", "暖和"),
                new Question( "прохладно liángkuai(лянкуай)", "凉快"),
                new Question( "влажный cháoshī(чаоши)", "潮湿"),
                new Question( "сухой gānzào(ганьцзао)", "干燥"),
                new Question( "буря bàofēngyǔ(баофэнъюй)", "暴风雨"),
                new Question( "землетрясение dìzhèn(дичжэнь)", "地震"),
                new Question( "наводнение hóngshuǐ(хуншуй)", "洪水"),
                new Question( "засуха gānhàn(ганьхань)", "干旱"),

               };
               questions11 = new List<Question>
               {
                   // ===== ВРЕМЯ =====
                new Question( "время shíjiān(шицзянь)", "时间"),
                new Question( "год nián(нянь)", "年"),
                new Question( "месяц yuè(юэ)", "月"),
                new Question( "день rì(жи)", "日"),
                new Question( "день tiān(тянь)", "天"),
                new Question( "час xiǎoshí(сяоши)", "小时"),
                new Question( "минута fēnzhōng(фэньчжун)", "分钟"),
                new Question( "секунда miǎo(мяо)", "秒"),
                new Question( "утро zǎoshang(цзаошан)", "早上"),
                new Question( "первая половина дня shàngwǔ(шанъу)", "上午"),
                new Question( "полдень zhōngwǔ(чжунъу)", "中午"),
                new Question( "вторая половина дня xiàwǔ(сяъу)", "下午"),
                new Question( "вечер wǎnshang(ваньшан)", "晚上"),
                new Question( "полночь bànyè(банье)", "半夜"),
                new Question( "раннее утро língchén(линчэнь)", "凌晨"),
                new Question( "сумерки huánghūn(хуанхунь)", "黄昏"),
                new Question( "рассвет límíng(лимин)", "黎明"),
                new Question( "вчера zuótiān(цзотянь)", "昨天"),
                new Question( "сегодня jīntiān(цзиньтянь)", "今天"),
                new Question( "завтра míngtiān(минтянь)", "明天"),
                new Question( "послезавтра hòutiān(хоутянь)", "后天"),
                new Question( "позавчера qiántiān(цяньтянь)", "前天"),
                new Question( "сейчас xiànzài(сяньцзай)", "现在"),
                new Question( "прошлое guòqù(гоцюй)", "过去"),
                new Question( "будущее wèilái(вэйлай)", "未来"),
                new Question( "древность gǔdài(гудай)", "古代"),
                new Question( "современность xiàndài(сяньдай)", "现代"),
                new Question( "век, столетие shìjì(шицзи)", "世纪"),
                new Question( "эпоха, годы niándài(няньдай)", "年代"),
                new Question( "сезон jìjié(цзицзе)", "季节"),
                new Question( "весна chūn(чунь)", "春"),
                new Question( "лето xià(ся)", "夏"),
                new Question( "осень qiū(цю)", "秋"),
                new Question( "зима dōng(дун)", "冬"),

               };
               questions12 = new List<Question>
               {
                   // ===== ШКОЛА =====
                new Question( "школа xuéxiào(сюэсяо)", "学校"),
                new Question( "университет dàxué(дасюэ)", "大学"),
                new Question( "класс, аудитория jiàoshì(цзяоши)", "教室"),
                new Question( "библиотека túshūguǎn(тушугуань)", "图书馆"),
                new Question( "книга shū(шу)", "书"),
                new Question( "тетрадь běnzi(бэньцзы)", "本子"),
                new Question( "ручка, кисть bǐ(би)", "笔"),
                new Question( "кисть для каллиграфии máobǐ(маоби)", "毛笔"),
                new Question( "тушь mò(мо)", "墨"),
                new Question( "бумага zhǐ(чжи)", "纸"),
                new Question( "тушечница yàn(янь)", "砚"),
                new Question( "иероглиф zì(цзы)", "字"),
                new Question( "слово cí(цы)", "词"),
                new Question( "предложение jùzi(цзюйцзы)", "句子"),
                new Question( "текст, урок kèwén(кэвэнь)", "课文"),
                new Question( "домашнее задание zuòyè(цзое)", "作业"),
                new Question( "экзамен kǎoshì(каоши)", "考试"),
                new Question( "оценка, результат chéngjì(чэнцзи)", "成绩"),
                new Question( "знания zhīshi(чжиши)", "知识"),
                new Question( "учёность xuéwèn(сюэвэнь)", "学问"),
                new Question( "учиться xuéxí(сюэси)", "学习"),
                new Question( "повторять fùxí(фуси)", "复习"),
                new Question( "упражняться liànxí(ляньси)", "练习"),
                new Question( "заучивать наизусть bèisòng(бэйсун)", "背诵"),
                new Question( "переписывать chāoxiě(чаосе)", "抄写"),
                new Question( "переводить fānyì(фаньи)", "翻译"),
                new Question( "объяснять jiěshì(цзеши)", "解释"),
                new Question( "вопрос, проблема wèntí(вэньти)", "问题"),
                new Question( "ответ dá'àn(даань)", "答案"),
                new Question( "выпуск, окончание bìyè(бие)", "毕业"),

               };
               questions13 = new List<Question>
               {
                   // ===== МЕДИЦИНА =====
               new Question( "здоровье jiànkāng(цзянькан)", "健康"),
               new Question( "заболеть shēngbìng(шэнбин)", "生病"),
                new Question( "болезнь bìng(бин)", "病"),
                new Question( "лекарство yào(яо)", "药"),
                new Question( "мазь yàogāo(яогао)", "药膏"),
                new Question( "таблетка yàowán(яовань)", "药丸"),
                new Question( "рана shāngkǒu(шанкоу)", "伤口"),
                new Question( "шрам shāngbā(шанба)", "伤疤"),
                new Question( "кровь xuè(сюэ)", "血"),
                new Question( "боль tòng(тун)", "痛"),
                new Question( "болеть téng(тэн)", "疼"),
                new Question( "температура fāshāo(фашао)", "发烧"),
                new Question( "простуда gǎnmào(ганьмао)", "感冒"),
                new Question( "кашель késou(кэсоу)", "咳嗽"),
                new Question( "отравление zhòngdú(чжунду)", "中毒"),
                new Question( "противоядие jiěyào(цзеяо)", "解药"),
                new Question( "лечить zhìliáo(чжиляо)", "治疗"),
                new Question( "лечить yīzhì(ичжи)", "医治"),
                new Question( "диагностика zhěnduàn(чжэньдуань)", "诊断"),
                new Question( "пульсовая диагностика bǎmài(бамай)", "把脉"),
                new Question( "иглоукалывание zhēnjiǔ(чжэньцзю)", "针灸"),
                new Question( "травы cǎoyào(цаояо)", "草药"),
                new Question( "пилюля dānyào(данъяо)", "丹药"),
                new Question( "духовная сила línglì(линли)", "灵力"),
                new Question( "перевязать bāozā(баоцза)", "包扎"),
                new Question( "бинт bēngdài(бэндай)", "绷带"),
                new Question( "выздороветь quányù(цюаньюй)", "痊愈"),
                new Question( "восстановиться kāngfù(канфу)", "康复"),
                new Question( "смерть sǐwáng(сыван)", "死亡"),
                new Question( "труп shītǐ(шити)", "尸体"),

               };
               questions14 = new List<Question>
               {
                  // ===== СРАЖЕНИЯ =====
                new Question( "война zhànzhēng(чжаньчжэн)", "战争"),
                new Question( "воевать dǎzhàng(дачжан)", "打仗"),
                new Question( "армия jūnduì(цзюньдуй)", "军队"),
                new Question( "огромная армия dàjūn(дацзюнь)", "大军"),
                new Question( "солдат shìbīng(шибин)", "士兵"),
                new Question( "генерал jiāngjūn(цзянцзюнь)", "将军"),
                new Question( "военачальник jiànglǐng(цзянлин)", "将领"),
                new Question( "оружие wǔqì(уци)", "武器"),
                new Question( "меч jiàn(цзянь)", "剑"),
                new Question( "сабля, нож dāo(дао)", "刀"),
                new Question( "копьё, ружьё qiāng(цян)", "枪"),
                new Question( "луки и стрелы gōngjiàn(гунцзянь)", "弓箭"),
                new Question( "щит dùn(дунь)", "盾"),
                new Question( "доспехи kuījiǎ(куйцзя)", "盔甲"),
                new Question( "атаковать gōngjī(гунцзи)", "攻击"),
                new Question( "обороняться fángshǒu(фаншоу)", "防守"),
                new Question( "наступать jìngōng(цзиньгун)", "进攻"),
                new Question( "отступать chètuì(чэтуй)", "撤退"),
                new Question( "окружать bāowéi(баовэй)", "包围"),
                new Question( "засада máifú(майфу)", "埋伏"),
                new Question( "внезапное нападение tōuxí(тоуси)", "偷袭"),
                new Question( "бой, сражение zhàndòu(чжаньдоу)", "战斗"),
                new Question( "жестокая битва sīshā(сыша)", "厮杀"),
                new Question( "победа shènglì(шэнли)", "胜利"),
                new Question( "поражение shībài(шибай)", "失败"),
                new Question( "сдаться tóuxiáng(тоусян)", "投降"),
                new Question( "пленник fúlǔ(фулу)", "俘虏"),
                new Question( "поле боя zhànchǎng(чжаньчан)", "战场"),
                new Question( "сигнальный огонь fēnghuǒ(фэнхо)", "烽火"),
                new Question( "боевой рог hàojiǎo(хаоцзяо)", "号角"),
                new Question( "боевое знамя zhànqí(чжаньци)", "战旗"),
                new Question( "кровавая битва xuèzhàn(сюэчжань)", "血战"),
                new Question( "резня в городе túchéng(тучэн)", "屠城"),
                new Question( "месть fùchóu(фучоу)", "复仇"),
                new Question( "ненависть chóuhèn(чоухэнь)", "仇恨"),
                new Question( "враг dírén(дижэнь)", "敌人"),
                new Question( "союзник méngyǒu(мэнъю)", "盟友"),
                new Question( "предательство bèipàn(бэйпань)", "背叛"),
                new Question( "верность zhōngchéng(чжунчэн)", "忠诚"),
                new Question( "жертва xīshēng(сишэн)", "牺牲"),

               };
               questions15 = new List<Question>
               {
                   // ===== ЕДА (БЛЮДА) =====
                new Question( "блюдо cài(цай)", "菜"),
                new Question( "меню càidān(цайдань)", "菜单"),
                new Question( "жарить (быстро) chǎo(чао)", "炒"),
                new Question( "варить zhǔ(чжу)", "煮"),
                new Question( "готовить на пару zhēng(чжэн)", "蒸"),
                new Question( "жарить (на огне) kǎo(као)", "烤"),
                new Question( "жарить (в масле) zhá(чжа)", "炸"),
                new Question( "тушить dùn(дунь)", "炖"),
                new Question( "смешивать (салат) bàn(бань)", "拌"),
                new Question( "резать qiē(це)", "切"),
                new Question( "пельмени (сычуаньские) chāoshǒu(чаошоу)", "抄手"),
                new Question( "пельмени jiǎozi(цзяоцзы)", "饺子"),
                new Question( "паровой пирожок bāozi(баоцзы)", "包子"),
                new Question( "паровой хлеб mántou(маньтоу)", "馒头"),
                new Question( "лапша miàntiáo(мяньтяо)", "面条"),
                new Question( "варёный рис mǐfàn(мифань)", "米饭"),
                new Question( "каша (жидкая) zhōu(чжоу)", "粥"),
                new Question( "суп tāng(тан)", "汤"),
                new Question( "масляный чай-суп yóuchá(юча)", "油茶"),
                new Question( "тофу dòufu(доуфу)", "豆腐"),
                new Question( "мясо ròu(жоу)", "肉"),
                new Question( "рыба yú(юй)", "鱼"),
                new Question( "креветка xiā(ся)", "虾"),
                new Question( "курица jī(цзи)", "鸡"),
                new Question( "утка yā(я)", "鸭"),
                new Question( "яйцо dàn(дань)", "蛋"),
                new Question( "овощи shūcài(шуцай)", "蔬菜"),
                new Question( "фрукты shuǐguǒ(шуйго)", "水果"),
                new Question( "закуска, десерт diǎnxin(дяньсинь)", "点心"),
                new Question( "сахар, конфета táng(тан)", "糖"),
                new Question( "уксус cù(цу)", "醋"),
                new Question( "соевый соус jiàngyóu(цзянъю)", "酱油"),
                new Question( "соль yán(янь)", "盐"),
                new Question( "перец чили làjiāo(лацзяо)", "辣椒"),
                new Question( "чеснок suàn(суань)", "蒜"),
                new Question( "имбирь jiāng(цзян)", "姜"),
                new Question( "зелёный лук cōng(цун)", "葱"),

               };
               questions16 = new List<Question>
               {
                  // ===== НАПИТКИ =====
                new Question( "вода shuǐ(шуй)", "水"),
                new Question( "чай chá(ча)", "茶"),
                new Question( "зелёный чай lǜchá(люйча)", "绿茶"),
                new Question( "чёрный чай hóngchá(хунча)", "红茶"),
                new Question( "цветочный чай huāchá(хуача)", "花茶"),
                new Question( "кофе kāfēi(кафэй)", "咖啡"),
                new Question( "молоко niúnǎi(нюнай)", "牛奶"),
                new Question( "сок guǒzhī(гочжи)", "果汁"),
                new Question( "алкоголь, вино jiǔ(цзю)", "酒"),
                new Question( "крепкий алкоголь báijiǔ(байцзю)", "白酒"),
                new Question( "вино «Белый цветок груши» líhuābái(лихуабай)", "梨花白"),
                new Question( "виноградное вино pútaojiǔ(путаоцзю)", "葡萄酒"),
                new Question( "пиво píjiǔ(пицзю)", "啤酒"),
                new Question( "суп (жидкий) tāng(тан)", "汤"),
                new Question( "жидкая каша zhōu(чжоу)", "粥"),
                new Question( "соевое молоко dòujiāng(доуцзян)", "豆浆"),
                new Question( "напиток из сливы suānméitāng(суаньмэйтан)", "酸梅汤"),
                new Question( "мёд fēngmì(фэнми)", "蜂蜜"),
                new Question( "лёд bīng(бин)", "冰"),
                new Question( "горячая вода rèshuǐ(жэшуй)", "热水"),
                new Question( "холодная вода liángshuǐ(ляншуй)", "凉水"),
                new Question( "чашка, стакан bēizi(бэйцзы)", "杯子"),
                new Question( "чайник cháhú(чаху)", "茶壶"),
                new Question( "винный сосуд jiǔhú(цзюху)", "酒壶"),
                new Question( "пиала, чаша wǎn(вань)", "碗"),
                new Question( "тарелка pánzi(паньцзы)", "盘子"),
                new Question( "палочки kuàizi(куайцзы)", "筷子"),
                new Question( "ложка sháozi(шаоцзы)", "勺子"),
                new Question( "нож dāo(дао)", "刀"),
                new Question( "вилка chāzi(чацзы)", "叉子"),

               };
               questions17 = new List<Question>
               {
                  // ===== МУЗЫКА =====
                new Question( "музыка yīnyuè(иньюэ)", "音乐"),
                new Question( "песня gē(гэ)", "歌"),
                new Question( "звук, голос shēngyīn(шэнъинь)", "声音"),
                new Question( "цинь (струнный инструмент) qín(цинь)", "琴"),
                new Question( "гуцинь (древняя цитра) gǔqín(гуцинь)", "古琴"),
                new Question( "пипа (лютня) pípá(пипа)", "琵琶"),
                new Question( "чжэн (гусли) zhēng(чжэн)", "筝"),
                new Question( "флейта dízi(дицзы)", "笛子"),
                new Question( "сяо (продольная флейта) xiāo(сяо)", "箫"),
                new Question( "барабан gǔ(гу)", "鼓"),
                new Question( "колокол zhōng(чжун)", "钟"),
                new Question( "колокольчик líng(лин)", "铃"),
                new Question( "струна xián(сянь)", "弦"),
                new Question( "мелодия qǔ(цюй)", "曲"),
                new Question( "тон, мелодия diào(дяо)", "调"),
                new Question( "ритм jiézòu(цзецзоу)", "节奏"),
                new Question( "мелодия xuánlǜ(сюаньлюй)", "旋律"),
                new Question( "гармония héshēng(хэшэн)", "和声"),
                new Question( "соло dúzòu(дуцзоу)", "独奏"),
                new Question( "хор héchàng(хэчан)", "合唱"),
                new Question( "танец wǔdǎo(удао)", "舞蹈"),
                new Question( "танец wǔ(у)", "舞"),
                new Question( "театр, драма xìjù(сицзюй)", "戏剧"),
                new Question( "спектакль xì(си)", "戏"),
                new Question( "выступление biǎoyǎn(бяоень)", "表演"),
                new Question( "зрители guānzhòng(гуаньчжун)", "观众"),
                new Question( "сцена wǔtái(утай)", "舞台"),
                new Question( "музыкальный инструмент yuèqì(юэци)", "乐器"),

               };
               questions18 = new List<Question>
               {
                  // ===== РЕЛИГИЯ =====
                new Question( "бог, дух shén(шэнь)", "神"),
                new Question( "бессмертный xiān(сянь)", "仙"),
                new Question( "будда fó(фо)", "佛"),
                new Question( "бодхисаттва púsà(пуса)", "菩萨"),
                new Question( "дао, путь dào(дао)", "道"),
                new Question( "небо tiān(тянь)", "天"),
                new Question( "земля dì(ди)", "地"),
                new Question( "призрак guǐ(гуй)", "鬼"),
                new Question( "душа hún(хунь)", "魂"),
                new Question( "душа (животная) pò(по)", "魄"),
                new Question( "дух, душа líng(лин)", "灵"),
                new Question( "загробный мир yīnjiān(иньцзянь)", "阴间"),
                new Question( "мир живых yángjiān(янцзянь)", "阳间"),
                new Question( "ад dìyù(диюй)", "地狱"),
                new Question( "рай tiāntáng(тяньтан)", "天堂"),
                new Question( "реинкарнация lúnhuí(луньхуэй)", "轮回"),
                new Question( "перерождение zhuǎnshì(чжуаньши)", "转世"),
                new Question( "возрождение chóngshēng(чуншэн)", "重生"),
                new Question( "культивация xiūliàn(сюлянь)", "修炼"),
                new Question( "культивация бессмертия xiūxiān(сюсянь)", "修仙"),
                new Question( "духовная сила línglì(линли)", "灵力"),
                new Question( "магия fǎshù(фашу)", "法术"),
                new Question( "талисман fú(фу)", "符"),
                new Question( "заклинание zhòu(чжоу)", "咒"),
                new Question( "барьер jiéjiè(цзецзе)", "结界"),
                new Question( "формация zhènfǎ(чжэньфа)", "阵法"),
                new Question( "пилюля dānyào(данъяо)", "丹药"),
                new Question( "магический артефакт fǎbǎo(фабао)", "法宝"),
                new Question( "божественное оружие shénqì(шэньци)", "神器"),
                new Question( "поклоняться jìbài(цзибай)", "祭拜"),
                new Question( "благовония xiānghuǒ(сянхо)", "香火"),
                new Question( "храм miào(мяо)", "庙"),
                new Question( "монастырь sì(сы)", "寺"),
                new Question( "родовой храм cítáng(цытан)", "祠堂"),
                new Question( "подносить gòng(гун)", "供"),
                new Question( "кланяться bài(бай)", "拜"),
                new Question( "молиться qídǎo(цидао)", "祈祷"),
                new Question( "судьба mìngyùn(минъюнь)", "命运"),
                new Question( "судьба (связь) yuánfèn(юаньфэнь)", "缘分"),
                new Question( "карма yīnguǒ(иньго)", "因果"),
                new Question( "возмездие bàoyìng(баоин)", "报应"),
                new Question( "заслуги gōngdé(гундэ)", "功德"),
                new Question( "грех zuìniè(цзуйне)", "罪孽"),
                new Question( "искупление jiùshú(цзюшу)", "救赎"),
                new Question( "милосердие cíbēi(цыбэй)", "慈悲"),
                new Question( "добро и зло shàn'è(шаньэ)", "善恶"),

               };
               questions19 = new List<Question>
               {
                   // ===== СЯНЬСЯ-ТЕРМИНЫ =====
                new Question( "культивация истины xiūzhēn(сючжэнь)", "修真"),
                new Question( "культивация бессмертия xiūxiān(сюсянь)", "修仙"),
                new Question( "культивация xiūliàn(сюлянь)", "修炼"),
                new Question( "уровень культивации xiūwéi(сювэй)", "修为"),
                new Question( "духовная сила línglì(линли)", "灵力"),
                new Question( "магия fǎshù(фашу)", "法术"),
                new Question( "барьер jiéjiè(цзецзе)", "结界"),
                new Question( "формация zhènfǎ(чжэньфа)", "阵法"),
                new Question( "талисман и заклинание fúzhòu(фучжоу)", "符咒"),
                new Question( "пилюля dānyào(данъяо)", "丹药"),
                new Question( "магический артефакт fǎbǎo(фабао)", "法宝"),
                new Question( "божественное оружие shénqì(шэньци)", "神器"),
                new Question( "меч jiàn(цзянь)", "剑"),
                new Question( "летающий меч fēijiàn(фэйцзянь)", "飞剑"),
                new Question( "сабля dāo(дао)", "刀"),
                new Question( "ивовая лоза liǔténg(лютэн)", "柳藤"),
                new Question( "прохождение испытания dùjié(дуцзе)", "渡劫"),
                new Question( "вознесение fēishēng(фэйшэн)", "飞升"),
                new Question( "внутренний демон xīnmó(синьмо)", "心魔"),
                new Question( "сойти с ума от культивации zǒuhuǒrùmó(цзоухо жумо)", "走火入魔"),
                new Question( "меридианы jīngmài(цзинмай)", "经脉"),
                new Question( "даньтянь dāntián(даньтянь)", "丹田"),
                new Question( "энергия ци qì(ци)", "气"),
                new Question( "духовное ядро línghé(линхэ)", "灵核"),
                new Question( "закладка фундамента zhùjī(чжуцзи)", "筑基"),
                new Question( "золотая пилюля jīndān(цзиньдань)", "金丹"),
                new Question( "душа-младенец yuányīng(юаньин)", "元婴"),
                new Question( "превращение в духа huàshén(хуашэнь)", "化神"),
                new Question( "бессмертный xiānrén(сяньжэнь)", "仙人"),
                new Question( "школа бессмертных xiānmén(сяньмэнь)", "仙门"),
                new Question( "школа, секта ménpài(мэньпай)", "门派"),
                new Question( "глава школы zhǎngmén(чжанмэнь)", "掌门"),
                new Question( "старейшина zhǎnglǎo(чжанлао)", "长老"),
                new Question( "ученик dìzǐ(дицзы)", "弟子"),
                new Question( "ученик túdì(туди)", "徒弟"),
                new Question( "почтенный учитель shīzūn(шицзунь)", "师尊"),
                new Question( "наставник shīfu(шифу)", "师父"),
                new Question( "родная школа shīmén(шимень)", "师门"),
                new Question( "старший брат по школе shīxiōng(шисюн)", "师兄"),
                new Question( "младший брат по школе shīdì(шиди)", "师弟"),
                new Question( "старшая сестра по школе shījiě(шицзе)", "师姐"),
                new Question( "младшая сестра по школе shīmèi(шимэй)", "师妹"),
                new Question( "глава союза méngzhǔ(мэнчжу)", "盟主"),
                new Question( "Владыка, попирающий бессмертных Tà Xiān Jūn(та сянь цзюнь)", "踏仙君"),
                new Question( "демон mó(мо)", "魔"),
                new Question( "оборотень, демон yāo(яо)", "妖"),
                new Question( "призрак guǐ(гуй)", "鬼"),
                new Question( "монстр guài(гуай)", "怪"),
                new Question( "зверь shòu(шоу)", "兽"),
                new Question( "духовный зверь língshòu(линшоу)", "灵兽"),
                new Question( "свирепый зверь xiōngshòu(сюншоу)", "凶兽"),

               };
               questions20 = new List<Question>
               {
                   // ===== ПРИРОДА И РАСТЕНИЯ =====
                new Question( "дерево shù(шу)", "树"),
                new Question( "лес sēnlín(сэньлинь)", "森林"),
                new Question( "джунгли cónglín(цунлинь)", "丛林"),
                new Question( "куст guànmù(гуаньму)", "灌木"),
                new Question( "цветок huā(хуа)", "花"),
                new Question( "трава cǎo(цао)", "草"),
                new Question( "лист yèzi(ецзы)", "叶子"),
                new Question( "ветка shùzhī(шучжи)", "树枝"),
                new Question( "корень shùgēn(шугэнь)", "树根"),
                new Question( "семя zhǒngzi(чжунцзы)", "种子"),
                new Question( "бамбук zhúzi(чжуцзы)", "竹子"),
                new Question( "сосна sōngshù(суншу)", "松树"),
                new Question( "ива liǔshù(люшу)", "柳树"),
                new Question( "персиковое дерево táoshù(таошу)", "桃树"),
                new Question( "цветок сливы méihuā(мэйхуа)", "梅花"),
                new Question( "орхидея lánhuā(ланьхуа)", "兰花"),
                new Question( "хризантема júhuā(цзюйхуа)", "菊花"),
                new Question( "лотос héhuā(хэхуа)", "荷花"),

               };
               questions21 = new List<Question>
               {
                   // ===== ФИНАНСЫ =====
                new Question( "деньги qián(цянь)", "钱"),
                new Question( "серебро (деньги) yínzi(иньцзы)", "银子"),
                new Question( "золото jīnzi(цзиньцзы)", "金子"),
                new Question( "медные монеты tóngqián(тунцянь)", "铜钱"),
                new Question( "слиток серебра yuánbǎo(юаньбао)", "元宝"),
                new Question( "драгоценности zhūbǎo(чжубао)", "珠宝"),
                new Question( "украшения shǒushì(шоуши)", "首饰"),
                new Question( "жемчуг zhēnzhū(чжэньчжу)", "珍珠"),
                new Question( "нефрит (зелёный) fěicuì(фэйцуй)", "翡翠"),
                new Question( "нефрит yù(юй)", "玉"),
                new Question( "золотой браслет jīn shǒuchuàn(цзинь шоучуань)", "金手钏"),
                new Question( "серебро (деньги) yínliǎng(иньлян)", "银两"),
                new Question( "богатство cáifù(цайфу)", "财富"),
                new Question( "имущество cáichǎn(цайчань)", "财产"),
                new Question( "богатый yǒuqián(юцянь)", "有钱"),
                new Question( "бедный pínqióng(пиньцюн)", "贫穷"),
                new Question( "богатый торговец fùshāng(фушан)", "富商"),
                new Question( "торговец shāngrén(шанжэнь)", "商人"),
                new Question( "торговля mǎimài(маймай)", "买卖"),
                new Question( "бизнес shēngyi(шэнъи)", "生意"),
                new Question( "цена jiàgé(цзягэ)", "价格"),
                new Question( "дешёвый piányi(пяньи)", "便宜"),
                new Question( "дорогой guì(гуй)", "贵"),
                new Question( "покупать mǎi(май)", "买"),
                new Question( "продавать mài(май)", "卖"),
                new Question( "платить fùqián(фуцянь)", "付钱"),
                new Question( "давать сдачу zhǎoqián(чжаоцянь)", "找钱"),
                new Question( "одалживать деньги jièqián(цзецянь)", "借钱"),
                new Question( "возвращать деньги huánqián(хуаньцянь)", "还钱"),
                new Question( "быть должным qiànqián(цяньцянь)", "欠钱"),
                new Question( "красть tōu(тоу)", "偷"),
                new Question( "грабить qiǎng(цян)", "抢"),
                new Question( "украденное zāngwù(цзанъу)", "赃物"),
                new Question( "выкупить себя shúshēn(шушэнь)", "赎身"),
                new Question( "зарабатывать zhuànqián(чжуаньцянь)", "赚钱"),
                new Question( "тратить деньги huāqián(хуацянь)", "花钱"),
                new Question( "экономить shěngqián(шэнцянь)", "省钱"),
                new Question( "тратить впустую làngfèi(ланфэй)", "浪费"),
                new Question( "долг zhài(чжай)", "债"),
                new Question( "проценты lìxī(лиси)", "利息"),

               };
               questions22 = new List<Question>
               {
                   // ===== ПУТЕШЕСТВИЯ =====
                new Question( "путешествие lǚxíng(люйсин)", "旅行"),
                new Question( "туризм lǚyóu(люйю)", "旅游"),
                new Question( "отправляться chūfā(чуфа)", "出发"),
                new Question( "прибывать dàodá(даода)", "到达"),
                new Question( "уезжать líkāi(ликай)", "离开"),
                new Question( "возвращаться huílái(хуэйлай)", "回来"),
                new Question( "возвращаться (туда) huíqù(хуэйцюй)", "回去"),
                new Question( "место отправления chūfādì(чуфади)", "出发地"),
                new Question( "место назначения mùdìdì(мудиди)", "目的地"),
                new Question( "маршрут lùxiàn(лусянь)", "路线"),
                new Question( "направление fāngxiàng(фансян)", "方向"),
                new Question( "карта dìtú(диту)", "地图"),
                new Question( "багаж xíngli(синли)", "行李"),
                new Question( "рюкзак bēibāo(бэйбао)", "背包"),
                new Question( "билет на поезд chēpiào(чэпяо)", "车票"),
                new Question( "авиабилет jīpiào(цзипяо)", "机票"),
                new Question( "билет на корабль chuánpiào(чуаньпяо)", "船票"),
                new Question( "паспорт hùzhào(хучжао)", "护照"),
                new Question( "виза qiānzhèng(цяньчжэн)", "签证"),
                new Question( "постоялый двор kèzhàn(кэчжань)", "客栈"),
                new Question( "гостиница lǚguǎn(люйгуань)", "旅馆"),
                new Question( "почтовая станция yìzhàn(ичжань)", "驿站"),
                new Question( "постоялый двор yìguǎn(игуань)", "驿馆"),
                new Question( "проводник xiàngdǎo(сяндао)", "向导"),
                new Question( "заблудиться mílù(милу)", "迷路"),
                new Question( "спрашивать дорогу wènlù(вэньлу)", "问路"),
                new Question( "вести, показывать дорогу dàilù(дайлу)", "带路"),
                new Question( "исследовать tànxiǎn(таньсянь)", "探险"),
                new Question( "рисковать màoxiǎn(маосянь)", "冒险"),
                new Question( "дальнее путешествие yuǎnxíng(юаньсин)", "远行"),
                new Question( "обратный путь guītú(гуйту)", "归途"),
                new Question( "по пути yántú(яньту)", "沿途"),
                new Question( "пейзаж fēngjǐng(фэнцзин)", "风景"),
                new Question( "горы и воды (пейзаж) shānshuǐ(шаньшуй)", "山水"),
                new Question( "достопримечательность míngshèng(миншэн)", "名胜"),
                new Question( "древние памятники gǔjì(гуцзи)", "古迹"),


               };
               questions23 = new List<Question>
               {
                  // ===== ОРУЖИЕ =====
                new Question( "оружие wǔqì(уци)", "武器"),
                new Question( "меч jiàn(цзянь)", "剑"),
                new Question( "сабля, нож dāo(дао)", "刀"),
                new Question( "копьё, ружьё qiāng(цян)", "枪"),
                new Question( "луки и стрелы gōngjiàn(гунцзянь)", "弓箭"),
                new Question( "щит dùn(дунь)", "盾"),
                new Question( "доспехи kuījiǎ(куйцзя)", "盔甲"),
                new Question( "лёгкие доспехи qīngkǎi(цинкай)", "轻铠"),
                new Question( "ивовая лоза liǔténg(лютэн)", "柳藤"),               
                new Question( "магический артефакт fǎbǎo(фабао)", "法宝"),
                new Question( "божественное оружие shénqì(шэньци)", "神器"),
                new Question( "скрытое оружие ànqì(аньци)", "暗器"),
                new Question( "стрела из рукава xiùjiàn(сюцзянь)", "袖箭"),
                new Question( "арбалет nǔ(ну)", "弩"),
                new Question( "кнут, плеть biān(бянь)", "鞭"),
                new Question( "посох zhàng(чжан)", "杖"),
                new Question( "веер shàn(шань)", "扇"),
                new Question( "техника меча jiànfǎ(цзяньфа)", "剑法"),
                new Question( "техника сабли dāofǎ(даофа)", "刀法"),
                new Question( "техника кулака quánfǎ(цюаньфа)", "拳法"),
                new Question( "лёгкая походка qīnggōng(цингун)", "轻功"),
                new Question( "внутренняя энергия nèigōng(нэйгун)", "内功"),
                new Question( "внешняя техника wàigōng(вайгун)", "外功"),
                new Question( "приём, движение zhāoshì(чжаоши)", "招式"),
                new Question( "атака gōngjī(гунцзи)", "攻击"),
                new Question( "защита fángyù(фанъюй)", "防御"),
                new Question( "уклонение shǎnbì(шаньби)", "闪避"),
                new Question( "контратака fǎnjī(фаньцзи)", "反击"),
                new Question( "аура меча jiànqì(цзяньци)", "剑气"),
                new Question( "блеск сабли dāoguāng(даогуан)", "刀光"),
                new Question( "тень меча jiànyǐng(цзяньин)", "剑影"),
                new Question( "аура убийства shāqì(шаци)", "杀气"),
                new Question( "боевой дух zhànyì(чжаньи)", "战意"),
                new Question( "магическая сила fǎlì(фали)", "法力"),
                new Question( "духовная сила línglì(линли)", "灵力"),
                new Question( "уровень культивации xiūwéi(сювэй)", "修为"),
                new Question( "уровень, состояние jìngjiè(цзинцзе)", "境界"),
                new Question( "прорыв tūpò(тупо)", "突破"),
                new Question( "постижение lǐngwù(линъу)", "领悟"),


               };
               questions24 = new List<Question>
               {
                  // ===== ТИТУЛЫ =====
                new Question( "император huángdì(хуанди)", "皇帝"),
                new Question( "Ваше Величество bìxià(бися)", "陛下"),
                new Question( "императрица huánghòu(хуанхоу)", "皇后"),
                new Question( "наследный принц tàizǐ(тайцзы)", "太子"),
                new Question( "Ваше Высочество diànxià(дянься)", "殿下"),
                new Question( "правитель, государь jūnwáng(цзюньван)", "君王"),
                new Question( "император, монарх dìwáng(диван)", "帝王"),
                new Question( "монарх jūnzhǔ(цзюньчжу)", "君主"),
                new Question( "Его Величество император huángdì bìxià(хуанди бися)", "皇帝陛下"),
                new Question( "повелитель zūnzhǔ(цзуньчжу)", "尊主"),
                new Question( "глава школы zhǎngmén(чжанмэнь)", "掌门"),
                new Question( "старейшина zhǎnglǎo(чжанлао)", "长老"),
                new Question( "глава союза méngzhǔ(мэнчжу)", "盟主"),
                new Question( "бессмертный владыка xiānzūn(сяньцзунь)", "仙尊"),
                new Question( "великий мастер zōngshī(цзунши)", "宗师"),
                new Question( "молодой господин gōngzǐ(гунцзы)", "公子"),
                new Question( "молодой господин shàoye(шаое)", "少爷"),
                new Question( "молодая госпожа xiǎojiě(сяоцзе)", "小姐"),
                new Question( "госпожа, жена fūren(фужэнь)", "夫人"),
                new Question( "ваша милость dàren(дарэнь)", "大人"),
                new Question( "старший, предшественник qiánbèi(цяньбэй)", "前辈"),
                new Question( "младший wǎnbèi(ваньбэй)", "晚辈"),
                new Question( "наставник shīfu(шифу)", "师父"),
                new Question( "почтенный учитель shīzūn(шицзунь)", "师尊"),
                new Question( "старший брат по школе shīxiōng(шисюн)", "师兄"),
                new Question( "младший брат по школе shīdì(шиди)", "师弟"),
                new Question( "старшая сестра по школе shījiě(шицзе)", "师姐"),
                new Question( "младшая сестра по школе shīmèi(шимэй)", "师妹"),
                new Question( "ученик dìzǐ(дицзы)", "弟子"),
                new Question( "ученик túdì(туди)", "徒弟"),
                new Question( "любимый ученик àitú(айту)", "爱徒"),
                new Question( "мятежный ученик nìtú(ниту)", "逆徒"),
                new Question( "грешный ученик niètú(нету)", "孽徒"),
                new Question( "Ваша милость géxià(гэся)", "阁下"),
                new Question( "Вы (книжн.) zúxià(цзуся)", "足下"),
                new Question( "я (скромно) zàixià(цзайся)", "在下"),
                new Question( "я (скромно) bǐrén(бирэнь)", "鄙人"),
                new Question( "я (высокомерно) běnzuò(бэньцзо)", "本座"),


               };
               questions25 = new List<Question>
               {
                  // ===== ЧУВСТВА =====
                new Question( "любовь àiqíng(айцин)", "爱情"),
                new Question( "чувства gǎnqíng(ганьцин)", "感情"),
                new Question( "родственные чувства qīnqíng(циньцин)", "亲情"),
                new Question( "дружба yǒuqíng(юцин)", "友情"),
                new Question( "слепая любовь chīqíng(чицин)", "痴情"),
                new Question( "одержимое сердце chīxīn(чисинь)", "痴心"),
                new Question( "навязчивая идея zhíniàn(чжинянь)", "执念"),
                new Question( "тосковать sīniàn(сынянь)", "思念"),
                new Question( "скучать xiǎngniàn(сяннянь)", "想念"),
                new Question( "вспоминать с тоской huáiniàn(хуайнянь)", "怀念"),
                new Question( "привязанность juànliàn(цзюаньлянь)", "眷恋"),
                new Question( "не хотеть расставаться liúliàn(люлянь)", "留恋"),
                new Question( "обожать àimù(айму)", "爱慕"),
                new Question( "тайная любовь ànliàn(аньлянь)", "暗恋"),
                new Question( "признаться в любви biǎobái(бяобай)", "表白"),
                new Question( "сердце дрогнуло xīndòng(синьдун)", "心动"),
                new Question( "сердцебиение xīntiào(синьтяо)", "心跳"),
                new Question( "болеть сердцем xīnténg(синьтэн)", "心疼"),
                new Question( "разбитое сердце xīn suì(синь суй)", "心碎"),
                new Question( "мягкосердечный xīnruǎn(синьжуань)", "心软"),
                new Question( "жестокосердный xīnhěn(синьхэнь)", "心狠"),
                new Question( "душевная боль xīntòng(синьтун)", "心痛"),
                new Question( "горечь на душе xīnsuān(синьсуань)", "心酸"),
                new Question( "разочарование xīnhán(синьхань)", "心寒"),
                new Question( "сердце умерло xīn sǐ(синь сы)", "心死"),
                new Question( "сердце как мёртвая вода xīn rú sǐshuǐ(синь жу сышуй)", "心如死水"),
                new Question( "все надежды рухнули wàn niàn jù huī(вань нянь цзюй хуэй)", "万念俱灰"),
                new Question( "боль невыносима tòng bù yù shēng(тун бу юй шэн)", "痛不欲生"),
                new Question( "жизнь хуже смерти shēng bù rú sǐ(шэн бу жу сы)", "生不如死"),
                new Question( "сердце разрывается gān cháng cùn duàn(гань чан цунь дуань)", "肝肠寸断"),
                new Question( "разрывающая душу боль sī xīn liè fèi(сы синь ле фэй)", "撕心裂肺"),
                new Question( "врезаться в память kè gǔ míng xīn(кэ гу мин синь)", "刻骨铭心"),
                new Question( "до самой смерти не изменится zhì sǐ bù yú(чжи сы бу юй)", "至死不渝"),
                new Question( "вместе до смерти shēng sǐ xiāng suí(шэн сы сян суй)", "生死相随"),
                new Question( "клятвы в любви hǎi shì shān méng(хай ши шань мэн)", "海誓山盟"),
                new Question( "глубокая привязанность yī wǎng qíng shēn(и ван цин шэнь)", "一往情深"),
                new Question( "любить только одного qíng yǒu dú zhōng(цин ю ду чжун)", "情有独钟"),
                new Question( "«белая луна» (идеал) bái yuèguāng(бай юэгуан)", "白月光"),
                new Question( "«родинка» (незабываемый) zhū shā zhì(чжу ша чжи)", "朱砂痣"),



               };
               questions26 = new List<Question>
               {
                new Question( "император huángdì(хуанди)", "皇帝"),
                new Question( "ругать, обзывать mà(ма)", "骂"),
                new Question( "выругаться, обозвать mà dào(ма дао)", "骂道"),
                new Question( "собака gǒu(гоу)", "狗"),
                new Question( "собачий сын gǒu érzi(гоу эрцзы)", "狗儿子"),
                new Question( "собачий щенок gǒu zǎizi(гоу цзайцзы)", "狗崽子"),
                new Question( "собачья тварь gǒu dōngxi(гоу дунси)", "狗东西"),
                new Question( "сукин сын gǒu niáng yǎng de(гоу нян ян дэ)", "狗娘养的"),
                new Question( "собачья тварь gǒu dōngxi(гоу дунси)", "狗东西"),
                new Question( "молочный щенок nǎi gǒu(най гоу)", "奶狗"),
                new Question( "вырасти в большую собаку zhǎng chéng dà gǒu(чжан чэн да гоу)", "长成大狗"),
                new Question( "старая собака lǎo gǒu(лао гоу)", "老狗"),
                new Question( "сдохнуть gǒu mìng guī tiān(гоу мин гуй тянь)", "狗命归天"),
                new Question( "глупая собака shǎ gǒu(ша гоу)", "傻狗"),
                new Question( "самец собаки, кобель gōnggǒu(гунгоу)", "公狗"),
                new Question( "самый сильный, хуже всего zuì lìhai(цзуй лихай)", "最厉害"),


               };
               questions27 = new List<Question>
               {
                new Question( "конечно dāngrán(данжань)", "当然"),
                new Question( "связанный, относящийся xiāngguān(сянгуань)", "相关"),
                new Question( "описание, образ xíngróng(синжун)", "形容"),
                new Question( "не слишком плохо bù suàn tài chà(бу суань тай ча)", "不算太差"),
                new Question( "например bǐrú(бижу)", "比如"),
                new Question( "мимолётная любовная связь lùshuǐ qíngyuán(лушуй цинъюань)", "露水情缘"),
                new Question( "притворный гнев yáng nù(ян ну)", "佯怒"),
                new Question( "кровать, ложе tà(та)", "榻"),
                

               };
               questions28 = new List<Question>
               {
                new Question( "сладкие речи tián yán(тянь янь)", "甜言"),
                new Question( "душа, дух húnpò(хуньпо)", "魂魄"),
                new Question( "смертоносное оружие xiōngqì(сюнци)", "凶器"),
                new Question( "жизнь, жизнь любимой qīngqīng xìngmìng(цинцин синмин)", "卿卿性命"),
                new Question( "хвастаться, выставлять напоказ xuànyào(сюаньяо)", "炫耀"),
                new Question( "все знают rén rén jiē zhī(жэнь жэнь цзе чжи)", "人人皆知"),
                new Question( "красивый, статный rén jùn(жэнь цзюнь)", "人俊"),
                new Question( "мощный, сильный qì měng(ци мэн)", "器猛"),

               };
               questions29 = new List<Question>
               {
                new Question( "пресытиться, насытиться tāo zú yì mǎn(тао цзу и мань)", "饕足意满"),
                new Question( "сильное волнение, влечение xīn chí shén yáo(синь чи шэнь яо)", "心弛神摇"),
                new Question( "нельзя не сказать bùdébù shuō(будэбу шо)", "不得不说"),
                new Question( "действительно, точно quèshí(цюэши)", "确实"),
                new Question( "вилять хвостом, угодничать yáo tóu bǎi wěi(яо тоу бай вэй)", "摇头摆尾"),
                



               };
               questions30 = new List<Question>
               {

                new Question( "вплоть до, пока не zhídào(чжидао)", "直到"),
                new Question( "культивация xiūzhēn(сючжэнь)", "修真"),
                new Question( "внезапно, резко zhòurán(чжоужань)", "骤然"),
                new Question( "исчезнуть, рассеяться xiāosàn(сяосань)", "消散"),
                new Question( "однажды yǒu yī tiān(ю и тянь)", "有一天"),
                new Question( "далёкая окраина yuǎn jiāng(юань цзян)", "远疆"),
                new Question( "маленькая школа сяньмэнь(сяньмэнь)", "仙门"),
               


               };
               questions31 = new List<Question>
               {
                new Question( "серо-белый huī bái(хуэй бай)", "灰白"),
                new Question( "немного похож на волка yǒudiǎn xiàng láng(юдянь сян лан)", "有点像狼"),
                new Question( "размером с дыню guā nàme dà(гуа намэ да)", "瓜那么大"),
                new Question( "глуповатый, дынеголовый guā tóu guā nǎo(гуа тоу гуа нао)", "瓜头瓜脑"),
                new Question( "круглый и толстый, как шарик gǔn pàng hún yuán(гунь пан хунь юань)", "滚胖浑圆"),

               };
               questions33 = new List<Question>
               {
                new Question( "но при этом ещё piān hái(пянь хай)", "偏还"),
                new Question( "грозный, величественный wēifēng(вэйфэн)", "威风"),
                new Question( "носиться как бешеный по всему залу mǎn dàdiàn fēng pǎo(мань дядянь фэн пао)", "满大殿疯跑"),
                new Question( "вдруг, внезапно hūrán(хурань)", "忽然"),
                new Question( "тихо, низким голосом dīshēng(дишэн)", "低声"),
                
                

               };
               questions34 = new List<Question>
               {
                new Question( "оба глаза shuāng mù(шуан му)", "双目"),
                new Question( "плотно закрыть hé shí(хэ ши)", "阖实"),
                new Question( "снова, опять fù yòu(фу ю)", "复又"),
                new Question( "жизнь rén shēng(жэнь шэн)", "人生"),
                new Question( "милость и позор chǒng rǔ(чун жу)", "宠辱"),
                new Question( "падения и взлёты diē dàng(де дан)", "跌宕"),
                new Question( "то вверх, то вниз huò qǐ huò fú(хо ци хо фу)", "或起或伏"),
               

               };
               questions35 = new List<Question>
               {
                new Question( "всё перепробовал, всё надоело wán nì le(вань ни лэ)", "玩腻了"),
                new Question( "скучно, пресно fáwèi(фавэй)", "乏味"),
                new Question( "одинокий gūdān(гундань)", "孤单"),
                new Question( "знакомые люди shúxī de rén(шуси дэ жэнь)", "熟悉的人"),
                new Question( "всё меньше yuè lái yuè shǎo(юэ лай юэ шао)", "越来越少"),
                new Question( "даже lián(лянь)", "连"),
          

               };
               questions36 = new List<Question>
               {
                new Question( "почти, примерно chàbuduō(чабу-до)", "差不多"),
                new Question( "пора заканчивать gāi jiéshù le(гай цзешу лэ)", "该结束了"),
                new Question( "фруктовая ваза guǒpán(гопань)", "果盘"),
                new Question( "отщипнуть, сорвать qiā xià(ця ся)", "掐下"),
                new Question( "сверкающий, прозрачный jīngyíng(цзинъин)", "晶莹"),
                new Question( "полный, сочный fēngrùn(фэнжунь)", "丰润"),
                new Question( "виноград pútao(путао)", "葡萄"),
                new Question( "медленно-неторопливо mànyōuyōu(мань-ю-ю)", "慢悠悠"),
                new Question( "содрать, очистить bō qù(бо цюй)", "剥去"),
                new Question( "фиолетовая кожура zǐpí(цзыпи)", "紫皮"),

               };
               questions37 = new List<Question>
               {
                new Question( "неторопливо, с достоинством cóngróng(цунжун)", "从容"),
                new Question( "искусно, мастерски xiánshú(сяньшу)", "娴熟"),
                new Question( "в шатре zhàng zhōng(чжан чжун)", "帐中"),
                new Question( "одежда, платье yīshān(ишань)", "衣衫"),
                new Question( "интерес угас, пресыщение yì xìng lán shān(и син лань шань)", "意兴阑珊"),
                new Question( "лень lǎn(лань)", "懒"),


               }; 

            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100001).Checked)
            {
                allquestions.AddRange(questions1);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100002).Checked)
            {
                allquestions.AddRange(questions2);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100003).Checked)
            {
                allquestions.AddRange(questions3);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100004).Checked)
            {
                allquestions.AddRange(questions4);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100005).Checked)
            {
                allquestions.AddRange(questions5);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100006).Checked)
            {
                allquestions.AddRange(questions6);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100007).Checked)
            {
                allquestions.AddRange(questions7);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100008).Checked)
            {
                allquestions.AddRange(questions8);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100009).Checked)
            {
                allquestions.AddRange(questions9);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100010).Checked)
            {
                allquestions.AddRange(questions10);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100011).Checked)
            {
                allquestions.AddRange(questions11);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100012).Checked)
            {
                allquestions.AddRange(questions12);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100013).Checked)
            {
                allquestions.AddRange(questions13);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100014).Checked)
            {
                allquestions.AddRange(questions14);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100015).Checked)
            {
                allquestions.AddRange(questions15);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100016).Checked)
            {
                allquestions.AddRange(questions16);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100017).Checked)
            {
                allquestions.AddRange(questions17);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100018).Checked)
            {
                allquestions.AddRange(questions18);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100019).Checked)
            {
                allquestions.AddRange(questions19);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100020).Checked)
            {
                allquestions.AddRange(questions20);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100021).Checked)
            {
                allquestions.AddRange(questions21);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100022).Checked)
            {
                allquestions.AddRange(questions22);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100023).Checked)
            {
                allquestions.AddRange(questions23);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100024).Checked)
            {
                allquestions.AddRange(questions24);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 100025).Checked)
            {
                allquestions.AddRange(questions25);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 200001).Checked)
            {
                allquestions.AddRange(questions26);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 200002).Checked)
            {
                allquestions.AddRange(questions27);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 200003).Checked)
            {
                allquestions.AddRange(questions28);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 200004).Checked)
            {
                allquestions.AddRange(questions29);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 200005).Checked)
            {
                allquestions.AddRange(questions30);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 200006).Checked)
            {
                allquestions.AddRange(questions31);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 200007).Checked)
            {
                allquestions.AddRange(questions32);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 200008).Checked)
            {
                allquestions.AddRange(questions33);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 200009).Checked)
            {
                allquestions.AddRange(questions34);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 200010).Checked)
            {
                allquestions.AddRange(questions35);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 200011).Checked)
            {
                allquestions.AddRange(questions36);
            }
            if (_mainForm.FindNodeByTag(_mainForm.treeView1.Nodes, 200012).Checked)
            {
                allquestions.AddRange(questions37);
            }

            questions = new List<Question>(allquestions);
        }
        private void DisplayQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                Question q = questions[currentQuestionIndex];
                lblQuestion.Text = $"Вопрос {currentQuestionIndex + 1}/{questions.Count}: \n{q.Text}";
                Random rand = new Random();
                List<string> AllAnswers = allquestions.Select(p => p.Answer).Where(answer => answer != q.Answer).ToList();
                
                for (int i = 0; i < buttons.Length; i++)
                {
                    if (i == 0)
                        buttons[i].Text = q.Answer;
                    else
                        buttons[i].Text = AllAnswers[rand.Next(AllAnswers.Count)];
                   
                }
                
                int n = buttons.Length;
                while (n > 1)
                {
                    n--;
                    int k = rand.Next(n + 1);
                    string temp = buttons[k].Text;
                    buttons[k].Text = buttons[n].Text;
                    buttons[n].Text = temp;
                }
               
            }
        }

        


        private void DisplayColors()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                
                if (buttons[i].Text == questions[currentQuestionIndex].Answer)
                {
                    
                    buttons[i].BackColor = Color.LightGreen;
                }
                else
                    buttons[i].BackColor = Color.Coral;
            }
        }


        private void Button_Button_Click(object sender, EventArgs e)
        {
            

            Button clickedButton = sender as Button;
            if (clickedButton != null && clickedButton.Tag != null)
            {
                // Читаем индекс из Tag
                
                string selectedAnswerText = clickedButton.Text;
                if (selectedAnswerText == null)
                {
                    MessageBox.Show("Пожалуйста, выберите вариант ответа!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Проверяем правильность ответа
                if (selectedAnswerText == questions[currentQuestionIndex].Answer)
                {
                    questions.RemoveAt(currentQuestionIndex);
                    currentQuestionIndex--;
                    
                    score++;
                }
                else
                {
                    DisplayColors();
                    return;
                }
                // Переход к следующему вопросу или финал
                currentQuestionIndex++;
                if (currentQuestionIndex < questions.Count)
                {
                    DisplayQuestion();
                    ResetColors();
                }
                else
                {
                    MessageBox.Show($"Тест окончен!\nВаш результат: {score} из {questions.Count}", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    questions = new List<Question>(allquestions);
                    // Перезапуск теста при желании
                    currentQuestionIndex = 0;
                    DisplayQuestion();
                    ResetColors();
                    this.Close();
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is Form1_roditel parent)
            {
                var existingForm2 = parent.MdiChildren.OfType<Form2>().FirstOrDefault();
                if (existingForm2 == null)
                {
                    Form2 form2Form = new Form2();
                    form2Form.MdiParent = parent;
                    form2Form.FormBorderStyle = FormBorderStyle.None;
                    form2Form.Dock = DockStyle.Fill; // Занимает всё пространство
                    form2Form.Show();
                }
                else existingForm2.Show();
            }
            this.Close();
           
        }
        private void ResetColors()
        {
            button1.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
            button4.BackColor = SystemColors.Control;
        }
    }
}
