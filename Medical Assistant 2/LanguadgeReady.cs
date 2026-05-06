using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MedicalAssistantCommunity
{

    public static class LanguadgeReady {
        public static string selectedlanguadge = "en";
        //Correct languadge months:
        public static LanguageText january = new LanguageText(
    "January",        // en
    "Ιανουάριος",     // el
    "Enero",          // es
    "一月",            // zh (Chinese Simplified)
    "जनवरी",          // hi
    "يناير",          // ar
    "Janeiro",        // pt
    "জানুয়ারি",       // bn
    "Январь",         // ru
    "1月",            // jp
    "ਜਨਵਰੀ",          // pa
    "Januar",         // de
    "Januari",        // jv
    "1월",            // ko
    "Janvier",        // fr
    "జనవరి",          // te
    "जानेवारी",        // mr
    "Ocak",           // tr
    "ஜனவரி",          // ta
    "Tháng 1",        // vi
    "جنوری",          // ur
    "Gennaio",        // it
    "มกราคม",        // th
    "જાન્યુઆરી",      // gu
    "Styczeń",        // pl
    "Січень",         // uk
    "ژانویه",         // fa
    "Januari",        // ms
    "Ianuarie",       // ro
    "Januari"         // nl
);
        public static LanguageText viewRange = new LanguageText(
    "View Range",        // en
    "Εύρος προβολής",    // el
    "Rango de vista",    // es
    "查看范围",           // zh (Chinese Simplified)
    "दृश्य सीमा",         // hi
    "نطاق العرض",        // ar
    "Intervalo de visualização", // pt
    "দেখার পরিসর",       // bn
    "Диапазон просмотра", // ru
    "表示範囲",           // jp
    "ਦੇਖਣ ਦੀ ਸੀਮਾ",      // pa
    "Ansichtsbereich",   // de
    "Jangkauan tampilan",// jv
    "보기 범위",          // ko
    "Plage d'affichage", // fr
    "వీక్షణ పరిధి",      // te
    "दृश्य श्रेणी",       // mr
    "Görüntü aralığı",   // tr
    "காட்சி வரம்பு",     // ta
    "Phạm vi xem",       // vi
    "دیکھنے کی حد",      // ur
    "Intervallo di visualizzazione", // it
    "ช่วงการแสดงผล",     // th
    "જોવાની શ્રેણી",      // gu
    "Zakres widoku",     // pl
    "Діапазон перегляду",// uk
    "محدوده نمایش",      // fa
    "Julat paparan",     // ms
    "Interval de vizualizare", // ro
    "Weergavebereik"     // nl
);
        public static LanguageText february = new LanguageText(
    "February",       // en
    "Φεβρουάριος",    // el
    "Febrero",        // es
    "二月",            // zh (Chinese Simplified)
    "फ़रवरी",         // hi
    "فبراير",         // ar
    "Fevereiro",      // pt
    "ফেব্রুয়ারি",     // bn
    "Февраль",        // ru
    "2月",            // jp
    "ਫ਼ਰਵਰੀ",         // pa
    "Februar",        // de
    "Februari",       // jv
    "2월",            // ko
    "Février",        // fr
    "ఫిబ్రవరి",        // te
    "फेब्रुवारी",      // mr
    "Şubat",          // tr
    "பிப்ரவரி",        // ta
    "Tháng 2",        // vi
    "فروری",          // ur
    "Febbraio",       // it
    "กุมภาพันธ์",     // th
    "ફેબ્રુઆરી",      // gu
    "Luty",           // pl
    "Лютий",          // uk
    "فوریه",          // fa
    "Februari",       // ms
    "Februarie",      // ro
    "Februari"        // nl
);
        public static LanguageText march = new LanguageText(
    "March",          // en
    "Μάρτιος",        // el
    "Marzo",          // es
    "三月",            // zh (Chinese Simplified)
    "मार्च",           // hi
    "مارس",           // ar
    "Março",          // pt
    "মার্চ",           // bn
    "Март",           // ru
    "3月",            // jp
    "ਮਾਰਚ",           // pa
    "März",           // de
    "Maret",          // jv
    "3월",            // ko
    "Mars",           // fr
    "మార్చి",          // te
    "मार्च",           // mr
    "Mart",           // tr
    "மார்ச்",          // ta
    "Tháng 3",        // vi
    "مارچ",           // ur
    "Marzo",          // it
    "มีนาคม",        // th
    "માર્ચ",           // gu
    "Marzec",         // pl
    "Березень",       // uk
    "مارس",           // fa
    "Mac",            // ms
    "Martie",         // ro
    "Maart"           // nl
);
        public static LanguageText april = new LanguageText(
    "April",          // en
    "Απρίλιος",       // el
    "Abril",          // es
    "四月",            // zh (Chinese Simplified)
    "अप्रैल",          // hi
    "أبريل",          // ar
    "Abril",          // pt
    "এপ্রিল",          // bn
    "Апрель",         // ru
    "4月",            // jp
    "ਅਪ੍ਰੈਲ",         // pa
    "April",          // de
    "April",          // jv
    "4월",            // ko
    "Avril",          // fr
    "ఏప్రిల్",         // te
    "एप्रिल",          // mr
    "Nisan",          // tr
    "ஏப்ரல்",          // ta
    "Tháng 4",        // vi
    "اپریل",          // ur
    "Aprile",         // it
    "เมษายน",        // th
    "એપ્રિલ",         // gu
    "Kwiecień",       // pl
    "Квітень",        // uk
    "آوریل",          // fa
    "April",          // ms
    "Aprilie",        // ro
    "April"           // nl
);
        public static LanguageText may = new LanguageText(
    "May",            // en
    "Μάιος",          // el
    "Mayo",           // es
    "五月",            // zh (Chinese Simplified)
    "मई",             // hi
    "مايو",           // ar
    "Maio",           // pt
    "মে",             // bn
    "Май",            // ru
    "5月",            // jp
    "ਮਈ",             // pa
    "Mai",            // de
    "Mei",            // jv
    "5월",            // ko
    "Mai",            // fr
    "మే",             // te
    "मे",             // mr
    "Mayıs",          // tr
    "மே",             // ta
    "Tháng 5",        // vi
    "مئی",            // ur
    "Maggio",         // it
    "พฤษภาคม",       // th
    "મે",             // gu
    "Maj",            // pl
    "Травень",        // uk
    "مه",             // fa
    "Mei",            // ms
    "Mai",            // ro
    "Mei"             // nl
);
        public static LanguageText june = new LanguageText(
    "June",           // en
    "Ιούνιος",        // el
    "Junio",          // es
    "六月",            // zh (Chinese Simplified)
    "जून",            // hi
    "يونيو",          // ar
    "Junho",          // pt
    "জুন",            // bn
    "Июнь",           // ru
    "6月",            // jp
    "ਜੂਨ",            // pa
    "Juni",           // de
    "Juni",           // jv
    "6월",            // ko
    "Juin",           // fr
    "జూన్",           // te
    "जून",            // mr
    "Haziran",        // tr
    "ஜூன்",            // ta
    "Tháng 6",        // vi
    "جون",            // ur
    "Giugno",         // it
    "มิถุนายน",       // th
    "જૂન",            // gu
    "Czerwiec",       // pl
    "Червень",        // uk
    "ژوئن",           // fa
    "Jun",            // ms
    "Iunie",          // ro
    "Juni"            // nl
);
        public static LanguageText july = new LanguageText(
    "July",           // en
    "Ιούλιος",        // el
    "Julio",          // es
    "七月",            // zh (Chinese Simplified)
    "जुलाई",          // hi
    "يوليو",          // ar
    "Julho",          // pt
    "জুলাই",          // bn
    "Июль",           // ru
    "7月",            // jp
    "ਜੁਲਾਈ",          // pa
    "Juli",           // de
    "Juli",           // jv
    "7월",            // ko
    "Juillet",        // fr
    "జూలై",           // te
    "जुलै",           // mr
    "Temmuz",         // tr
    "ஜூலை",            // ta
    "Tháng 7",        // vi
    "جولائی",          // ur
    "Luglio",         // it
    "กรกฎาคม",       // th
    "જુલાઈ",          // gu
    "Lipiec",         // pl
    "Липень",         // uk
    "ژوئیه",          // fa
    "Julai",          // ms
    "Iulie",          // ro
    "Juli"            // nl
);
        public static LanguageText august = new LanguageText(
    "August",         // en
    "Αύγουστος",      // el
    "Agosto",         // es
    "八月",            // zh (Chinese Simplified)
    "अगस्त",          // hi
    "أغسطس",          // ar
    "Agosto",         // pt
    "আগস্ট",          // bn
    "Август",         // ru
    "8月",            // jp
    "ਅਗਸਤ",          // pa
    "August",         // de
    "Agustus",        // jv
    "8월",            // ko
    "Août",           // fr
    "ఆగస్టు",         // te
    "ऑगस्ट",          // mr
    "Ağustos",        // tr
    "ஆகஸ்ட்",         // ta
    "Tháng 8",        // vi
    "اگست",           // ur
    "Agosto",         // it
    "สิงหาคม",       // th
    "ઓગસ્ટ",          // gu
    "Sierpień",       // pl
    "Серпень",        // uk
    "اوت",            // fa
    "Ogos",           // ms
    "August",         // ro
    "Augustus"        // nl
);
        public static LanguageText september = new LanguageText(
    "September",      // en
    "Σεπτέμβριος",    // el
    "Septiembre",     // es
    "九月",            // zh (Chinese Simplified)
    "सितंबर",         // hi
    "سبتمبر",         // ar
    "Setembro",       // pt
    "সেপ্টেম্বর",     // bn
    "Сентябрь",       // ru
    "9月",            // jp
    "ਸਤੰਬਰ",         // pa
    "September",      // de
    "September",      // jv
    "9월",            // ko
    "Septembre",      // fr
    "సెప్టెంబర్",      // te
    "सप्टेंबर",        // mr
    "Eylül",          // tr
    "செப்டம்பர்",      // ta
    "Tháng 9",        // vi
    "ستمبر",          // ur
    "Settembre",      // it
    "กันยายน",        // th
    "સપ્ટેમ્બર",      // gu
    "Wrzesień",       // pl
    "Вересень",       // uk
    "سپتامبر",        // fa
    "September",      // ms
    "Septembrie",     // ro
    "September"       // nl
);
        public static LanguageText october = new LanguageText(
    "October",        // en
    "Οκτώβριος",      // el
    "Octubre",        // es
    "十月",            // zh (Chinese Simplified)
    "अक्टूबर",        // hi
    "أكتوبر",         // ar
    "Outubro",        // pt
    "অক্টোবর",        // bn
    "Октябрь",        // ru
    "10月",           // jp
    "ਅਕਤੂਬਰ",         // pa
    "Oktober",        // de
    "Oktober",        // jv
    "10월",           // ko
    "Octobre",        // fr
    "అక్టోబర్",        // te
    "ऑक्टोबर",        // mr
    "Ekim",           // tr
    "அக்டோபர்",        // ta
    "Tháng 10",       // vi
    "اکتوبر",         // ur
    "Ottobre",        // it
    "ตุลาคม",        // th
    "ઓક્ટોબર",        // gu
    "Październik",    // pl
    "Жовтень",        // uk
    "اکتبر",          // fa
    "Oktober",        // ms
    "Octombrie",      // ro
    "Oktober"         // nl
);
        public static LanguageText november = new LanguageText(
        "November",       // en
        "Νοέμβριος",      // el
        "Noviembre",      // es
        "十一月",          // zh (Chinese Simplified)
        "नवंबर",          // hi
        "نوفمبر",         // ar
        "Novembro",       // pt
        "নভেম্বর",        // bn
        "Ноябрь",         // ru
        "11月",           // jp
        "ਨਵੰਬਰ",          // pa
        "November",       // de
        "November",       // jv
        "11월",           // ko
        "Novembre",       // fr
        "నవంబర్",         // te
        "नोव्हेंबर",       // mr
        "Kasım",          // tr
        "நவம்பர்",         // ta
        "Tháng 11",       // vi
        "نومبر",          // ur
        "Novembre",       // it
        "พฤศจิกายน",     // th
        "નવેમ્બર",        // gu
        "Listopad",       // pl
        "Листопад",       // uk
        "نوامبر",         // fa
        "November",       // ms
        "Noiembrie",      // ro
        "November"        // nl
    );
        public static LanguageText december = new LanguageText(
    "December",       // en
    "Δεκέμβριος",     // el
    "Diciembre",      // es
    "十二月",          // zh (Chinese Simplified)
    "दिसंबर",         // hi
    "ديسمبر",         // ar
    "Dezembro",       // pt
    "ডিসেম্বর",       // bn
    "Декабрь",        // ru
    "12月",           // jp
    "ਦਸੰਬਰ",          // pa
    "Dezember",       // de
    "Desember",       // jv
    "12월",           // ko
    "Décembre",       // fr
    "డిసెంబర్",        // te
    "डिसेंबर",         // mr
    "Aralık",         // tr
    "டிசம்பர்",        // ta
    "Tháng 12",       // vi
    "دسمبر",          // ur
    "Dicembre",       // it
    "ธันวาคม",        // th
    "ડિસેમ્બર",        // gu
    "Grudzień",       // pl
    "Грудень",        // uk
    "دسامبر",         // fa
    "Disember",       // ms
    "Decembrie",      // ro
    "December"        // nl
);

        public static LanguageText enterMedicationName = new LanguageText(
   "Please enter the medication name.",  // en
   "Παρακαλώ εισάγετε το όνομα του φαρμάκου.",  // el
   "Por favor, introduzca el nombre del medicamento.",  // es
   "请输入药物名称。",  // zh
   "कृपया दवा का नाम दर्ज करें।",  // hi
   "يرجى إدخال اسم الدواء.",  // ar
   "Por favor, insira o nome do medicamento.",  // pt
   "দয়া করে ওষুধের নাম লিখুন।",  // bn
   "Пожалуйста, введите название лекарства.",  // ru
   "薬の名前を入力してください。",  // jp
   "ਕਿਰਪਾ ਕਰਕੇ ਦਵਾਈ ਦਾ ਨਾਮ ਦਰਜ ਕਰੋ।",  // pa
   "Bitte geben Sie den Namen des Medikaments ein.",  // de
   "Mangga lebokna jeneng obat.",  // jv
   "약 이름을 입력해 주세요.",  // ko
   "Veuillez entrer le nom du médicament.",  // fr
   "దయచేసి ఔషధం పేరు నమోదు చేయండి.",  // te
   "कृपया औषधाचे नाव प्रविष्ट करा.",  // mr
   "Lütfen ilaç adını girin.",  // tr
   "தயவுசெய்து மருந்தின் பெயரை உள்ளிடவும்.",  // ta
   "Vui lòng nhập tên thuốc.",  // vi
   "براہ کرم دوا کا نام درج کریں۔",  // ur
   "Inserisci il nome del farmaco.",  // it
   "กรุณากรอกชื่อยา",  // th
   "કૃપા કરીને દવાના નામ દાખલ કરો.",  // gu
   "Proszę wprowadzić nazwę leku.",  // pl
   "Будь ласка, введіть назву ліків.",  // uk
   "لطفاً نام دارو را وارد کنید.",  // fa
   "Sila masukkan nama ubat.",  // ms
   "Vă rugăm să introduceți numele medicamentului.",  // ro
   "Voer de naam van het medicijn in."  // nl
);
        public static LanguageText monday = new LanguageText(
   "Monday",  // en
   "Δευτέρα",  // el
   "Lunes",  // es
   "星期一",  // zh
   "सोमवार",  // hi
   "الاثنين",  // ar
   "Segunda-feira",  // pt
   "সোমবার",  // bn
   "Понедельник",  // ru
   "月曜日",  // jp
   "ਸੋਮਵਾਰ",  // pa
   "Montag",  // de
   "Senin",  // jv
   "월요일",  // ko
   "Lundi",  // fr
   "సోమవారం",  // te
   "सोमवार",  // mr
   "Pazartesi",  // tr
   "திங்கட்கிழமை",  // ta
   "Thứ Hai",  // vi
   "پیر",  // ur
   "Lunedì",  // it
   "วันจันทร์",  // th
   "સોમવાર",  // gu
   "Poniedziałek",  // pl
   "Понеділок",  // uk
   "دوشنبه",  // fa
   "Isnin",  // ms
   "Luni",  // ro
   "Maandag"  // nl
);

        public static LanguageText tuesday = new LanguageText(
           "Tuesday",  // en
           "Τρίτη",  // el
           "Martes",  // es
           "星期二",  // zh
           "मंगलवार",  // hi
           "الثلاثاء",  // ar
           "Terça-feira",  // pt
           "মঙ্গলবার",  // bn
           "Вторник",  // ru
           "火曜日",  // jp
           "ਮੰਗਲਵਾਰ",  // pa
           "Dienstag",  // de
           "Selasa",  // jv
           "화요일",  // ko
           "Mardi",  // fr
           "మంగళవారం",  // te
           "मंगळवार",  // mr
           "Salı",  // tr
           "செவ்வாய்க்கிழமை",  // ta
           "Thứ Ba",  // vi
           "منگل",  // ur
           "Martedì",  // it
           "วันอังคาร",  // th
           "મંગળવાર",  // gu
           "Wtorek",  // pl
           "Вівторок",  // uk
           "سه‌شنبه",  // fa
           "Selasa",  // ms
           "Marți",  // ro
           "Dinsdag"  // nl
        );

        public static LanguageText wednesday = new LanguageText(
           "Wednesday",  // en
           "Τετάρτη",  // el
           "Miércoles",  // es
           "星期三",  // zh
           "बुधवार",  // hi
           "الأربعاء",  // ar
           "Quarta-feira",  // pt
           "বুধবার",  // bn
           "Среда",  // ru
           "水曜日",  // jp
           "ਬੁੱਧਵਾਰ",  // pa
           "Mittwoch",  // de
           "Rabu",  // jv
           "수요일",  // ko
           "Mercredi",  // fr
           "బుధవారం",  // te
           "बुधवार",  // mr
           "Çarşamba",  // tr
           "புதன்கிழமை",  // ta
           "Thứ Tư",  // vi
           "بدھ",  // ur
           "Mercoledì",  // it
           "วันพุธ",  // th
           "બુધવાર",  // gu
           "Środa",  // pl
           "Середа",  // uk
           "چهارشنبه",  // fa
           "Rabu",  // ms
           "Miercuri",  // ro
           "Woensdag"  // nl
        );

        public static LanguageText thursday = new LanguageText(
           "Thursday",  // en
           "Πέμπτη",  // el
           "Jueves",  // es
           "星期四",  // zh
           "गुरुवार",  // hi
           "الخميس",  // ar
           "Quinta-feira",  // pt
           "বৃহস্পতিবার",  // bn
           "Четверг",  // ru
           "木曜日",  // jp
           "ਵੀਰਵਾਰ",  // pa
           "Donnerstag",  // de
           "Kamis",  // jv
           "목요일",  // ko
           "Jeudi",  // fr
           "గురువారం",  // te
           "गुरुवार",  // mr
           "Perşembe",  // tr
           "வியாழக்கிழமை",  // ta
           "Thứ Năm",  // vi
           "جمعرات",  // ur
           "Giovedì",  // it
           "วันพฤหัสบดี",  // th
           "ગુરુવાર",  // gu
           "Czwartek",  // pl
           "Четвер",  // uk
           "پنجشنبه",  // fa
           "Khamis",  // ms
           "Joi",  // ro
           "Donderdag"  // nl
        );

        public static LanguageText friday = new LanguageText(
           "Friday",  // en
           "Παρασκευή",  // el
           "Viernes",  // es
           "星期五",  // zh
           "शुक्रवार",  // hi
           "الجمعة",  // ar
           "Sexta-feira",  // pt
           "শুক্রবার",  // bn
           "Пятница",  // ru
           "金曜日",  // jp
           "ਸ਼ੁੱਕਰਵਾਰ",  // pa
           "Freitag",  // de
           "Jumat",  // jv
           "금요일",  // ko
           "Vendredi",  // fr
           "శుక్రవారం",  // te
           "शुक्रवार",  // mr
           "Cuma",  // tr
           "வெள்ளிக்கிழமை",  // ta
           "Thứ Sáu",  // vi
           "جمعہ",  // ur
           "Venerdì",  // it
           "วันศุกร์",  // th
           "શુક્રવાર",  // gu
           "Piątek",  // pl
           "П’ятниця",  // uk
           "جمعه",  // fa
           "Jumaat",  // ms
           "Vineri",  // ro
           "Vrijdag"  // nl
        );

        public static LanguageText saturday = new LanguageText(
           "Saturday",  // en
           "Σάββατο",  // el
           "Sábado",  // es
           "星期六",  // zh
           "शनिवार",  // hi
           "السبت",  // ar
           "Sábado",  // pt
           "শনিবার",  // bn
           "Суббота",  // ru
           "土曜日",  // jp
           "ਸ਼ਨੀਵਾਰ",  // pa
           "Samstag",  // de
           "Sabtu",  // jv
           "토요일",  // ko
           "Samedi",  // fr
           "శనివారం",  // te
           "शनिवार",  // mr
           "Cumartesi",  // tr
           "சனிக்கிழமை",  // ta
           "Thứ Bảy",  // vi
           "ہفتہ",  // ur
           "Sabato",  // it
           "วันเสาร์",  // th
           "શનિવાર",  // gu
           "Sobota",  // pl
           "Субота",  // uk
           "شنبه",  // fa
           "Sabtu",  // ms
           "Sâmbătă",  // ro
           "Zaterdag"  // nl
        );

        public static LanguageText sunday = new LanguageText(
           "Sunday",  // en
           "Κυριακή",  // el
           "Domingo",  // es
           "星期日",  // zh
           "रविवार",  // hi
           "الأحد",  // ar
           "Domingo",  // pt
           "রবিবার",  // bn
           "Воскресенье",  // ru
           "日曜日",  // jp
           "ਐਤਵਾਰ",  // pa
           "Sonntag",  // de
           "Minggu",  // jv
           "일요일",  // ko
           "Dimanche",  // fr
           "ఆదివారం",  // te
           "रविवार",  // mr
           "Pazar",  // tr
           "ஞாயிற்றுக்கிழமை",  // ta
           "Chủ Nhật",  // vi
           "اتوار",  // ur
           "Domenica",  // it
           "วันอาทิตย์",  // th
           "રવિવાર",  // gu
           "Niedziela",  // pl
           "Неділя",  // uk
           "یکشنبه",  // fa
           "Ahad",  // ms
           "Duminică",  // ro
           "Zondag"  // nl
        );





        public static LanguageText patient = new LanguageText(
   "Patient",           // en
   "Ασθενής",           // el
   "Paciente",          // es
   "患者",               // zh (Chinese Simplified)
   "रोगी",              // hi
   "مريض",              // ar
   "Paciente",          // pt
   "রোগী",              // bn
   "Пациент",           // ru
   "患者",               // jp
   "ਮਰੀਜ਼",              // pa
   "Patient",           // de
   "Pasien",            // jv
   "환자",               // ko
   "Patient",           // fr
   "రోగి",              // te
   "रुग्ण",              // mr
   "Hasta",             // tr
   "நோயாளி",            // ta
   "Bệnh nhân",         // vi
   "مریض",              // ur
   "Paziente",          // it
   "ผู้ป่วย",            // th
   "દર્દી",              // gu
   "Pacjent",           // pl
   "Пацієнт",           // uk
   "بیمار",             // fa
   "Pesakit",           // ms
   "Pacient",           // ro
   "Patiënt"            // nl
);
        public static LanguageText patients = new LanguageText(
    "Patients",          // en
    "Ασθενείς",          // el
    "Pacientes",         // es
    "患者",               // zh
    "रोगी",              // hi
    "مرضى",              // ar
    "Pacientes",         // pt
    "রোগীরা",            // bn
    "Пациенты",          // ru
    "患者",               // jp
    "ਮਰੀਜ਼",              // pa
    "Patienten",         // de
    "Pasien",            // jv
    "환자들",             // ko
    "Patients",          // fr
    "రోగులు",            // te
    "रुग्ण",              // mr
    "Hastalar",          // tr
    "நோயாளிகள்",         // ta
    "Bệnh nhân",         // vi
    "مریض",              // ur
    "Pazienti",          // it
    "ผู้ป่วย",            // th
    "દર્દીઓ",             // gu
    "Pacjenci",          // pl
    "Пацієнти",          // uk
    "بیماران",           // fa
    "Pesakit",           // ms
    "Pacienți",          // ro
    "Patiënten"          // nl
);
        public static LanguageText patientName = new LanguageText(
    "Patient Name",        // en
    "Όνομα Ασθενούς",      // el
    "Nombre del paciente", // es
    "患者姓名",              // zh (Chinese Simplified)
    "रोगी का नाम",          // hi
    "اسم المريض",          // ar
    "Nome do paciente",    // pt
    "রোগীর নাম",           // bn
    "Имя пациента",        // ru
    "患者名",               // jp
    "ਮਰੀਜ਼ ਦਾ ਨਾਮ",         // pa
    "Patientenname",       // de
    "Jeneng pasien",       // jv
    "환자 이름",            // ko
    "Nom du patient",      // fr
    "రోగి పేరు",            // te
    "रुग्णाचे नाव",         // mr
    "Hasta adı",           // tr
    "நோயாளியின் பெயர்",    // ta
    "Tên bệnh nhân",       // vi
    "مریض کا نام",         // ur
    "Nome del paziente",   // it
    "ชื่อผู้ป่วย",          // th
    "દર્દીનું નામ",         // gu
    "Imię pacjenta",       // pl
    "Ім'я пацієнта",       // uk
    "نام بیمار",           // fa
    "Nama pesakit",        // ms
    "Numele pacientului", // ro
    "Naam van de patiënt" // nl
);
        public static LanguageText patientDataManagement = new LanguageText(
   "Patient Data Management",     // en
   "Διαχείριση Δεδομένων Ασθενούς", // el
   "Gestión de datos del paciente", // es
   "患者数据管理",                   // zh (Chinese Simplified)
   "रोगी डेटा प्रबंधन",            // hi
   "إدارة بيانات المريض",           // ar
   "Gestão de dados do paciente",  // pt
   "রোগীর তথ্য ব্যবস্থাপনা",        // bn
   "Управление данными пациента",  // ru
   "患者データ管理",                 // jp
   "ਮਰੀਜ਼ ਡਾਟਾ ਪ੍ਰਬੰਧਨ",            // pa
   "Patientendatenverwaltung",     // de
   "Manajemen data pasien",        // jv
   "환자 데이터 관리",              // ko
   "Gestion des données patient",  // fr
   "రోగి డేటా నిర్వహణ",            // te
   "रुग्ण डेटा व्यवस्थापन",        // mr
   "Hasta veri yönetimi",          // tr
   "நோயாளி தரவு மேலாண்மை",        // ta
   "Quản lý dữ liệu bệnh nhân",    // vi
   "مریض کے ڈیٹا کا انتظام",       // ur
   "Gestione dei dati del paziente", // it
   "การจัดการข้อมูลผู้ป่วย",      // th
   "દર્દી ડેટા મેનેજમેન્ટ",        // gu
   "Zarządzanie danymi pacjenta",  // pl
   "Управління даними пацієнта",   // uk
   "مدیریت داده‌های بیمار",       // fa
   "Pengurusan data pesakit",      // ms
   "Gestionarea datelor pacientului", // ro
   "Beheer van patiëntgegevens"    // nl
);
        public static LanguageText patientRegistry = new LanguageText(
        "Patient Registry",          // en
        "Μητρώο Ασθενών",            // el
        "Registro de pacientes",     // es
        "患者登记",                   // zh (Chinese Simplified)
        "रोगी रजिस्टर",              // hi
        "سجل المرضى",                // ar
        "Registro de pacientes",     // pt
        "রোগী নিবন্ধন",              // bn
        "Реестр пациентов",          // ru
        "患者登録",                   // jp
        "ਮਰੀਜ਼ ਰਜਿਸਟਰ",              // pa
        "Patientenregister",         // de
        "Daftar pasien",             // jv
        "환자 등록부",                // ko
        "Registre des patients",     // fr
        "రోగి నమోదు",                // te
        "रुग्ण नोंदणी",              // mr
        "Hasta kayıtları",           // tr
        "நோயாளி பதிவு",             // ta
        "Sổ đăng ký bệnh nhân",      // vi
        "مریض رجسٹر",               // ur
        "Registro pazienti",         // it
        "ทะเบียนผู้ป่วย",           // th
        "દર્દી નોંધણી",              // gu
        "Rejestr pacjentów",         // pl
        "Реєстр пацієнтів",          // uk
        "ثبت بیماران",              // fa
        "Daftar pesakit",            // ms
        "Registrul pacienților",     // ro
        "Patiëntenregister"         // nl
    );
        public static LanguageText newPatient = new LanguageText(
"New Patient",         // en
"Νέος Ασθενής",        // el
"Nuevo paciente",      // es
"新患者",               // zh (Chinese Simplified)
"नया रोगी",            // hi
"مريض جديد",           // ar
"Novo paciente",       // pt
"নতুন রোগী",           // bn
"Новый пациент",       // ru
"新規患者",             // jp
"ਨਵਾਂ ਮਰੀਜ਼",          // pa
"Neuer Patient",       // de
"Pasien baru",         // jv
"신규 환자",           // ko
"Nouveau patient",     // fr
"కొత్త రోగి",          // te
"नवीन रुग्ण",          // mr
"Yeni hasta",          // tr
"புதிய நோயாளி",        // ta
"Bệnh nhân mới",       // vi
"نیا مریض",            // ur
"Nuovo paziente",      // it
"ผู้ป่วยใหม่",         // th
"નવો દર્દી",           // gu
"Nowy pacjent",        // pl
"Новий пацієнт",       // uk
"بیمار جدید",          // fa
"Pesakit baharu",      // ms
"Pacient nou",         // ro
"Nieuwe patiënt"       // nl
);
        public static LanguageText registerPatient = new LanguageText(
    "Register Patient",        // en
    "Καταχώρηση Ασθενούς",     // el
    "Registrar paciente",      // es
    "登记患者",                 // zh (Chinese Simplified)
    "रोगी पंजीकरण",           // hi
    "تسجيل المريض",           // ar
    "Registrar paciente",      // pt
    "রোগী নিবন্ধন",            // bn
    "Регистрация пациента",    // ru
    "患者登録",                 // jp
    "ਮਰੀਜ਼ ਰਜਿਸਟਰ ਕਰੋ",        // pa
    "Patient registrieren",    // de
    "Daftarkan pasien",        // jv
    "환자 등록",               // ko
    "Enregistrer le patient",  // fr
    "రోగి నమోదు",             // te
    "रुग्ण नोंदणी",           // mr
    "Hasta kaydı",            // tr
    "நோயாளி பதிவு",          // ta
    "Đăng ký bệnh nhân",      // vi
    "مریض رجسٹر کریں",        // ur
    "Registrare paziente",    // it
    "ลงทะเบียนผู้ป่วย",       // th
    "દર્દી નોંધણી",           // gu
    "Zarejestruj pacjenta",   // pl
    "Реєстрація пацієнта",    // uk
    "ثبت بیمار",             // fa
    "Daftar pesakit",         // ms
    "Înregistrare pacient",   // ro
    "Patiënt registreren"     // nl
);
        public static LanguageText searchPatients = new LanguageText(
    "Search patients",      // en
    "Αναζήτηση ασθενών",    // el
    "Buscar pacientes",     // es
    "搜索患者",               // zh (Chinese Simplified)
    "रोगियों की खोज",        // hi
    "البحث عن المرضى",       // ar
    "Pesquisar pacientes",  // pt
    "রোগী অনুসন্ধান",        // bn
    "Поиск пациентов",      // ru
    "患者検索",               // jp
    "ਮਰੀਜ਼ਾਂ ਦੀ ਖੋਜ",        // pa
    "Patienten suchen",     // de
    "Nggoleki pasien",      // jv
    "환자 검색",             // ko
    "Rechercher des patients", // fr
    "రోగుల కోసం శోధించండి",  // te
    "रुग्ण शोधा",            // mr
    "Hasta ara",            // tr
    "நோயாளிகளைத் தேடு",     // ta
    "Tìm kiếm bệnh nhân",   // vi
    "مریضوں کی تلاش",       // ur
    "Cerca pazienti",       // it
    "ค้นหาผู้ป่วย",         // th
    "દર્દીઓ શોધો",          // gu
    "Szukaj pacjentów",     // pl
    "Пошук пацієнтів",      // uk
    "جستجوی بیماران",       // fa
    "Cari pesakit",         // ms
    "Căutare pacienți",     // ro
    "Patiënten zoeken"      // nl
);


        public static LanguageText prescription = new LanguageText(
  "Prescription",        // en
  "Συνταγή",             // el
  "Receta",              // es
  "处方",                 // zh (Chinese Simplified)
  "नुस्खा",              // hi
  "وصفة طبية",           // ar
  "Receita médica",      // pt
  "প্রেসক্রিপশন",        // bn
  "Рецепт",              // ru
  "処方箋",               // jp
  "ਨੁਸਖਾ",               // pa
  "Rezept",              // de
  "Resep",               // jv
  "처방전",               // ko
  "Ordonnance",          // fr
  "ప్రిస్క్రిప్షన్",      // te
  "प्रिस्क्रिप्शन",       // mr
  "Reçete",              // tr
  "மருந்து சீட்டு",       // ta
  "Đơn thuốc",           // vi
  "نسخہ",                // ur
  "Prescrizione",        // it
  "ใบสั่งยา",           // th
  "પ્રિસ્ક્રિપ્શન",      // gu
  "Recepta",             // pl
  "Рецепт",              // uk
  "نسخه",                // fa
  "Preskripsi",          // ms
  "Rețetă",              // ro
  "Voorschrift"          // nl
);
        public static LanguageText prescriptionDirections = new LanguageText(
        "Prescription Directions",   // en
        "Οδηγίες Συνταγής",          // el
        "Instrucciones de la receta",// es
        "用药说明",                   // zh (Chinese Simplified)
        "दवा के निर्देश",            // hi
        "تعليمات الوصفة الطبية",     // ar
        "Instruções da receita",     // pt
        "ওষুধের নির্দেশনা",          // bn
        "Инструкции по рецепту",     // ru
        "処方指示",                  // jp
        "ਨੁਸਖੇ ਦੀਆਂ ਹਦਾਇਤਾਂ",       // pa
        "Anweisungen zum Rezept",    // de
        "Pandhuan resep",            // jv
        "처방 지침",                 // ko
        "Instructions de prescription", // fr
        "మందుల సూచనలు",            // te
        "औषधाच्या सूचना",           // mr
        "Reçete talimatları",        // tr
        "மருந்து வழிமுறைகள்",        // ta
        "Hướng dẫn đơn thuốc",       // vi
        "نسخے کی ہدایات",            // ur
        "Istruzioni della prescrizione", // it
        "คำแนะนำการใช้ยา",          // th
        "દવા માટેની સૂચનાઓ",        // gu
        "Instrukcje recepty",        // pl
        "Інструкції до рецепта",     // uk
        "دستورالعمل نسخه",          // fa
        "Arahan preskripsi",         // ms
        "Instrucțiuni de prescripție", // ro
        "Voorschrift instructies"    // nl
    );

        public static LanguageText appointment = new LanguageText(
    "Appointment",         // en
    "Ραντεβού",            // el
    "Cita",                // es
    "预约",                 // zh (Chinese Simplified)
    "नियुक्ति",            // hi
    "موعد",                // ar
    "Consulta",           // pt
    "অ্যাপয়েন্টমেন্ট",     // bn
    "Приём",              // ru
    "予約",                 // jp
    "ਮੁਲਾਕਾਤ",             // pa
    "Termin",             // de
    "Janji temu",         // jv
    "예약",                // ko
    "Rendez-vous",        // fr
    "నియామకం",            // te
    "अपॉइंटमेंट",         // mr
    "Randevu",            // tr
    "நியமனம்",            // ta
    "Cuộc hẹn",           // vi
    "ملاقات",             // ur
    "Appuntamento",       // it
    "การนัดหมาย",         // th
    "નિયુક્તિ",            // gu
    "Wizyta",             // pl
    "Прийом",             // uk
    "قرار ملاقات",        // fa
    "Janji temu",         // ms
    "Programare",         // ro
    "Afspraak"            // nl
);
        public static LanguageText appointments = new LanguageText(
   "Appointments",        // en
   "Ραντεβού",            // el
   "Citas",               // es
   "预约",                 // zh (Chinese Simplified)
   "नियुक्तियाँ",         // hi
   "مواعيد",              // ar
   "Consultas",           // pt
   "অ্যাপয়েন্টমেন্টসমূহ", // bn
   "Приёмы",              // ru
   "予約",                 // jp
   "ਮੁਲਾਕਾਤਾਂ",          // pa
   "Termine",             // de
   "Janji temu",          // jv
   "예약",                // ko
   "Rendez-vous",         // fr
   "నియామకాలు",          // te
   "अपॉइंटमेंट्स",        // mr
   "Randevular",          // tr
   "நியமனங்கள்",         // ta
   "Các cuộc hẹn",        // vi
   "ملاقاتیں",            // ur
   "Appuntamenti",        // it
   "การนัดหมาย",          // th
   "નિયુક્તિઓ",           // gu
   "Wizyty",              // pl
   "Прийоми",             // uk
   "قرار ملاقات‌ها",      // fa
   "Janji temu",          // ms
   "Programări",          // ro
   "Afspraken"            // nl
);
        public static LanguageText scheduleAppointment = new LanguageText(
    "Schedule Appointment",     // en
    "Προγραμματισμός Ραντεβού",  // el
    "Programar cita",           // es
    "安排预约",                  // zh (Chinese Simplified)
    "अपॉइंटमेंट निर्धारित करें", // hi
    "جدولة موعد",              // ar
    "Agendar consulta",         // pt
    "অ্যাপয়েন্টমেন্ট নির্ধারণ", // bn
    "Записать на приём",        // ru
    "予約を取る",               // jp
    "ਮੁਲਾਕਾਤ ਤੈਅ ਕਰੋ",         // pa
    "Termin vereinbaren",       // de
    "Jadwalkan janji temu",     // jv
    "예약 잡기",               // ko
    "Planifier un rendez-vous", // fr
    "అపాయింట్మెంట్ షెడ్యూల్ చేయండి", // te
    "अपॉइंटमेंट ठरवा",        // mr
    "Randevu planla",           // tr
    "நியமனம் திட்டமிடு",        // ta
    "Lên lịch hẹn",             // vi
    "ملاقات طے کریں",          // ur
    "Prenotare appuntamento",   // it
    "นัดหมาย",                 // th
    "નિયુક્તિ નક્કી કરો",      // gu
    "Umów wizytę",              // pl
    "Запланувати прийом",       // uk
    "تنظیم قرار ملاقات",       // fa
    "Jadualkan janji temu",     // ms
    "Programează o programare", // ro
    "Afspraak plannen"         // nl
);
        public static LanguageText bookAppointment = new LanguageText(
    "Book Appointment",     // en
    "Κλείσιμο Ραντεβού",    // el
    "Reservar cita",        // es
    "预约",                  // zh (Chinese Simplified)
    "अपॉइंटमेंट बुक करें",  // hi
    "حجز موعد",             // ar
    "Marcar consulta",      // pt
    "অ্যাপয়েন্টমেন্ট বুক",  // bn
    "Записаться на приём",  // ru
    "予約する",              // jp
    "ਮੁਲਾਕਾਤ ਬੁੱਕ ਕਰੋ",     // pa
    "Termin buchen",        // de
    "Tempah janji temu",    // jv
    "예약하기",             // ko
    "Prendre rendez-vous",  // fr
    "అపాయింట్మెంట్ బుక్ చేయండి", // te
    "अपॉइंटमेंट बुक करा",  // mr
    "Randevu al",           // tr
    "நியமனம் பதிவு செய்",   // ta
    "Đặt lịch hẹn",         // vi
    "ملاقات بک کریں",       // ur
    "Prenota appuntamento", // it
    "จองนัดหมาย",          // th
    "નિયુક્તિ બુક કરો",     // gu
    "Umów wizytę",          // pl
    "Записатися на прийом", // uk
    "رزرو نوبت",            // fa
    "Tempah janji temu",    // ms
    "Programează vizită",   // ro
    "Afspraak boeken"       // nl
);


        public static LanguageText date = new LanguageText(
    "Date",              // en
    "Ημερομηνία",        // el
    "Fecha",             // es
    "日期",               // zh (Chinese Simplified)
    "तारीख",             // hi
    "تاريخ",             // ar
    "Data",              // pt
    "তারিখ",             // bn
    "Дата",              // ru
    "日付",               // jp
    "ਤਾਰੀਖ",             // pa
    "Datum",             // de
    "Tanggal",           // jv
    "날짜",               // ko
    "Date",              // fr
    "తేదీ",              // te
    "तारीख",             // mr
    "Tarih",             // tr
    "தேதி",              // ta
    "Ngày",              // vi
    "تاریخ",             // ur
    "Data",              // it
    "วันที่",             // th
    "તારીખ",             // gu
    "Data",              // pl
    "Дата",              // uk
    "تاریخ",             // fa
    "Tarikh",            // ms
    "Dată",              // ro
    "Datum"              // nl
);
        public static LanguageText time = new LanguageText(
    "Time",             // en
    "Ώρα",              // el
    "Hora",             // es
    "时间",              // zh (Chinese Simplified)
    "समय",              // hi
    "وقت",              // ar
    "Hora",             // pt
    "সময়",             // bn
    "Время",            // ru
    "時間",              // jp
    "ਸਮਾਂ",             // pa
    "Zeit",             // de
    "Wektu",            // jv
    "시간",              // ko
    "Temps",            // fr
    "సమయం",            // te
    "वेळ",              // mr
    "Saat",             // tr
    "நேரம்",            // ta
    "Thời gian",        // vi
    "وقت",              // ur
    "Tempo",            // it
    "เวลา",             // th
    "સમય",              // gu
    "Czas",             // pl
    "Час",              // uk
    "زمان",             // fa
    "Masa",             // ms
    "Timp",             // ro
    "Tijd"              // nl
);
        public static LanguageText days = new LanguageText(
      "Days",            // en
      "Ημέρες",          // el
      "Días",            // es
      "天",               // zh (Chinese Simplified)
      "दिन",             // hi
      "أيام",            // ar
      "Dias",            // pt
      "দিন",             // bn
      "Дни",             // ru
      "日",               // jp
      "ਦਿਨ",             // pa
      "Tage",            // de
      "Dina",            // jv
      "일",               // ko
      "Jours",           // fr
      "రోజులు",          // te
      "दिवस",            // mr
      "Günler",          // tr
      "நாட்கள்",         // ta
      "Ngày",            // vi
      "دن",              // ur
      "Giorni",          // it
      "วัน",             // th
      "દિવસો",           // gu
      "Dni",             // pl
      "Дні",             // uk
      "روزها",           // fa
      "Hari",            // ms
      "Zile",            // ro
      "Dagen"            // nl
  );


        public static LanguageText dateOfBirth = new LanguageText(
    "Date of Birth",        // en
    "Ημερομηνία Γέννησης",  // el
    "Fecha de nacimiento",  // es
    "出生日期",               // zh (Chinese Simplified)
    "जन्म तिथि",            // hi
    "تاريخ الميلاد",        // ar
    "Data de nascimento",   // pt
    "জন্ম তারিখ",           // bn
    "Дата рождения",        // ru
    "生年月日",              // jp
    "ਜਨਮ ਮਿਤੀ",             // pa
    "Geburtsdatum",         // de
    "Tanggal lahir",        // jv
    "생년월일",             // ko
    "Date de naissance",    // fr
    "పుట్టిన తేదీ",          // te
    "जन्मतारीख",           // mr
    "Doğum tarihi",         // tr
    "பிறந்த தேதி",          // ta
    "Ngày sinh",            // vi
    "تاریخ پیدائش",         // ur
    "Data di nascita",      // it
    "วันเกิด",             // th
    "જન્મ તારીખ",          // gu
    "Data urodzenia",       // pl
    "Дата народження",      // uk
    "تاریخ تولد",          // fa
    "Tarikh lahir",         // ms
    "Data nașterii",        // ro
    "Geboortedatum"         // nl
);
        public static LanguageText socialSecurityNumber = new LanguageText(
        "Social Security Number",   // en
        "ΑΜΚΑ",                     // el (best UI practice in Greece)
        "Número de seguro social",  // es
        "社会保障号码",               // zh (Chinese Simplified)
        "सामाजिक सुरक्षा संख्या",     // hi
        "رقم الضمان الاجتماعي",      // ar
        "Número de segurança social", // pt
        "সামাজিক নিরাপত্তা নম্বর",   // bn
        "Номер социального страхования", // ru
        "社会保障番号",              // jp
        "ਸਮਾਜਿਕ ਸੁਰੱਖਿਆ ਨੰਬਰ",     // pa
        "Sozialversicherungsnummer", // de
        "Nombor keselamatan sosial", // jv
        "사회 보장 번호",           // ko
        "Numéro de sécurité sociale", // fr
        "సామాజిక భద్రత సంఖ్య",     // te
        "सामाजिक सुरक्षा क्रमांक",   // mr
        "Sosyal güvenlik numarası", // tr
        "சமூக பாதுகாப்பு எண்",     // ta
        "Số an sinh xã hội",        // vi
        "سماجی تحفظ نمبر",         // ur
        "Numero di previdenza sociale", // it
        "หมายเลขประกันสังคม",      // th
        "સામાજિક સુરક્ષા નંબર",    // gu
        "Numer ubezpieczenia społecznego", // pl
        "Номер соціального страхування",   // uk
        "شماره تأمین اجتماعی",     // fa
        "Nombor keselamatan sosial", // ms
        "Număr de asigurare socială", // ro
        "Burgerservicenummer"      // nl
    );
        public static LanguageText sex = new LanguageText(
    "Sex",              // en
    "Φύλο",             // el
    "Sexo",             // es
    "性别",              // zh (Chinese Simplified)
    "लिंग",             // hi
    "الجنس",            // ar
    "Sexo",             // pt
    "লিঙ্গ",            // bn
    "Пол",              // ru
    "性別",              // jp
    "ਲਿੰਗ",             // pa
    "Geschlecht",       // de
    "Jenis kelamin",    // jv
    "성별",             // ko
    "Sexe",             // fr
    "లింగం",            // te
    "लिंग",             // mr
    "Cinsiyet",         // tr
    "பாலினம்",          // ta
    "Giới tính",        // vi
    "جنس",              // ur
    "Sesso",            // it
    "เพศ",              // th
    "લિંગ",             // gu
    "Płeć",             // pl
    "Стать",            // uk
    "جنسیت",            // fa
    "Jantina",          // ms
    "Sex",              // ro
    "Geslacht"          // nl
);



        public static LanguageText configuration = new LanguageText(
     "Configuration",        // en
     "Διαμόρφωση",           // el
     "Configuración",        // es
     "配置",                  // zh (Chinese Simplified)
     "कॉन्फ़िगरेशन",         // hi
     "التكوين",              // ar
     "Configuração",         // pt
     "কনফিগারেশন",          // bn
     "Конфигурация",         // ru
     "設定",                  // jp
     "ਸੰਰਚਨਾ",              // pa
     "Konfiguration",        // de
     "Konfigurasi",          // jv
     "구성",                  // ko
     "Configuration",        // fr
     "కాన్ఫిగరేషన్",         // te
     "कॉन्फिगरेशन",         // mr
     "Yapılandırma",         // tr
     "கட்டமைப்பு",          // ta
     "Cấu hình",             // vi
     "ترتیب",               // ur
     "Configurazione",       // it
     "การกำหนดค่า",         // th
     "રૂપરેખાંકન",          // gu
     "Konfiguracja",         // pl
     "Конфігурація",         // uk
     "پیکربندی",            // fa
     "Konfigurasi",          // ms
     "Configurație",         // ro
     "Configuratie"          // nl
 );

        public static LanguageText systemSettings = new LanguageText(
            "System Settings",      // en
            "Ρυθμίσεις συστήματος", // el
            "Configuración del sistema", // es
            "系统设置",              // zh
            "सिस्टम सेटिंग्स",       // hi
            "إعدادات النظام",       // ar
            "Configurações do sistema", // pt
            "সিস্টেম সেটিংস",       // bn
            "Системные настройки",  // ru
            "システム設定",          // jp
            "ਸਿਸਟਮ ਸੈਟਿੰਗਜ਼",       // pa
            "Systemeinstellungen",  // de
            "Setelan sistem",       // jv
            "시스템 설정",          // ko
            "Paramètres système",   // fr
            "సిస్టమ్ సెట్టింగులు",   // te
            "सिस्टम सेटिंग्ज",       // mr
            "Sistem ayarları",      // tr
            "அமைப்பு அமைப்புகள்",  // ta
            "Cài đặt hệ thống",     // vi
            "سسٹم سیٹنگز",         // ur
            "Impostazioni di sistema", // it
            "การตั้งค่าระบบ",      // th
            "સિસ્ટમ સેટિંગ્સ",     // gu
            "Ustawienia systemowe",// pl
            "Системні налаштування", // uk
            "تنظیمات سیستم",       // fa
            "Tetapan sistem",      // ms
            "Setări sistem",       // ro
            "Systeeminstellingen"  // nl
        );

        public static LanguageText interfaceLanguage = new LanguageText(
            "Interface language",   // en
            "Γλώσσα διεπαφής",      // el
            "Idioma de la interfaz",// es
            "界面语言",              // zh
            "इंटरफ़ेस भाषा",        // hi
            "لغة الواجهة",          // ar
            "Idioma da interface",  // pt
            "ইন্টারফেস ভাষা",       // bn
            "Язык интерфейса",      // ru
            "インターフェース言語", // jp
            "ਇੰਟਰਫੇਸ ਭਾਸ਼ਾ",      // pa
            "Oberflächensprache",   // de
            "Basa antarmuka",       // jv
            "인터페이스 언어",     // ko
            "Langue de l'interface",// fr
            "ఇంటర్‌ఫేస్ భాష",      // te
            "इंटरफेस भाषा",        // mr
            "Arayüz dili",          // tr
            "இடைமுக மொழி",        // ta
            "Ngôn ngữ giao diện",   // vi
            "انٹرفیس زبان",        // ur
            "Lingua dell'interfaccia", // it
            "ภาษาของอินเทอร์เฟซ", // th
            "ઇન્ટરફેસ ભાષા",      // gu
            "Język interfejsu",     // pl
            "Мова інтерфейсу",     // uk
            "زبان رابط کاربری",    // fa
            "Bahasa antara muka",   // ms
            "Limba interfeței",     // ro
            "Interfacetaal"         // nl
        );

        public static LanguageText selectLanguage = new LanguageText(
            "Select language",      // en
            "Επιλογή γλώσσας",      // el
            "Seleccionar idioma",   // es
            "选择语言",              // zh
            "भाषा चुनें",           // hi
            "اختر اللغة",           // ar
            "Selecionar idioma",    // pt
            "ভাষা নির্বাচন করুন",   // bn
            "Выберите язык",       // ru
            "言語を選択",           // jp
            "ਭਾਸ਼ਾ ਚੁਣੋ",          // pa
            "Sprache auswählen",    // de
            "Pilih basa",           // jv
            "언어 선택",           // ko
            "Sélectionner la langue", // fr
            "భాషను ఎంచుకోండి",     // te
            "भाषा निवडा",           // mr
            "Dil seçin",            // tr
            "மொழியைத் தேர்ந்தெடுக்கவும்", // ta
            "Chọn ngôn ngữ",        // vi
            "زبان منتخب کریں",      // ur
            "Seleziona lingua",     // it
            "เลือกภาษา",            // th
            "ભાષા પસંદ કરો",       // gu
            "Wybierz język",        // pl
            "Виберіть мову",       // uk
            "انتخاب زبان",          // fa
            "Pilih bahasa",         // ms
            "Selectați limba",      // ro
            "Selecteer taal"        // nl
        );

        public static LanguageText cancel = new LanguageText(
            "Cancel",              // en
            "Ακύρωση",             // el
            "Cancelar",            // es
            "取消",                 // zh
            "रद्द करें",           // hi
            "إلغاء",               // ar
            "Cancelar",            // pt
            "বাতিল",               // bn
            "Отмена",              // ru
            "キャンセル",          // jp
            "ਰੱਦ ਕਰੋ",             // pa
            "Abbrechen",           // de
            "Batal",               // jv
            "취소",                // ko
            "Annuler",             // fr
            "రద్దు",               // te
            "रद्द करा",            // mr
            "İptal",               // tr
            "ரத்து",               // ta
            "Hủy",                 // vi
            "منسوخ کریں",          // ur
            "Annulla",             // it
            "ยกเลิก",             // th
            "રદ કરો",              // gu
            "Anuluj",              // pl
            "Скасувати",           // uk
            "لغو",                 // fa
            "Batal",               // ms
            "Anulează",            // ro
            "Annuleren"            // nl
        );

        public static LanguageText saveChanges = new LanguageText(
            "Save Changes",        // en
            "Αποθήκευση αλλαγών",  // el
            "Guardar cambios",     // es
            "保存更改",             // zh
            "परिवर्तन सहेजें",     // hi
            "حفظ التغييرات",       // ar
            "Salvar alterações",   // pt
            "পরিবর্তন সংরক্ষণ করুন", // bn
            "Сохранить изменения", // ru
            "変更を保存",           // jp
            "ਬਦਲਾਅ ਸੰਭਾਲੋ",       // pa
            "Änderungen speichern",// de
            "Simpen owah-owahan",  // jv
            "변경 사항 저장",      // ko
            "Enregistrer les modifications", // fr
            "మార్పులను సేవ్ చేయండి", // te
            "बदल जतन करा",         // mr
            "Değişiklikleri kaydet", // tr
            "மாற்றங்களைச் சேமிக்கவும்", // ta
            "Lưu thay đổi",        // vi
            "تبدیلیاں محفوظ کریں", // ur
            "Salva modifiche",     // it
            "บันทึกการเปลี่ยนแปลง", // th
            "ફેરફારો સાચવો",       // gu
            "Zapisz zmiany",       // pl
            "Зберегти зміни",      // uk
            "ذخیره تغییرات",       // fa
            "Simpan perubahan",    // ms
            "Salvează modificările", // ro
            "Wijzigingen opslaan"  // nl
        );



        public static LanguageText prescriptionDetails = new LanguageText(
    "PRESCRIPTION DETAILS", // en
    "ΛΕΠΤΟΜΕΡΕΙΕΣ ΣΥΝΤΑΓΗΣ", // el
    "DETALLES DE LA RECETA", // es
    "处方详情",              // zh
    "प्रिस्क्रिप्शन विवरण",   // hi
    "تفاصيل الوصفة",        // ar
    "DETALHES DA PRESCRIÇÃO", // pt
    "প্রেসক্রিপশনের বিবরণ",  // bn
    "ДЕТАЛИ РЕЦЕПТА",       // ru
    "処方の詳細",            // jp
    "ਨੁਸਖੇ ਦੇ ਵੇਰਵੇ",       // pa
    "REZEPTDETAILS",        // de
    "RINCIAN RESEP",        // jv
    "처방 세부 정보",        // ko
    "DÉTAILS DE L'ORDONNANCE", // fr
    "ప్రిస్క్రిప్షన్ వివరాలు", // te
    "प्रिस्क्रिप्शन तपशील",  // mr
    "REÇETE DETAYLARI",     // tr
    "மருந்து சீட்டு விவரங்கள்", // ta
    "CHI TIẾT ĐƠN THUỐC",   // vi
    "نسخے کی تفصیلات",      // ur
    "DETTAGLI PRESCRIZIONE", // it
    "รายละเอียดใบสั่งยา",   // th
    "પ્રિસ્ક્રિપ્શન વિગતો", // gu
    "SZCZEGÓŁY RECEPTY",    // pl
    "ДЕТАЛІ РЕЦЕПТА",       // uk
    "جزئیات نسخه",         // fa
    "BUTIRAN PRESKRIPSI",   // ms
    "DETALII PRESCRIPȚIE",  // ro
    "VOORSCHRIFTDETAILS"    // nl
);

        public static LanguageText issuePrescription = new LanguageText(
            "Issue Prescription",   // en
            "Έκδοση συνταγής",      // el
            "Emitir receta",        // es
            "开具处方",              // zh
            "प्रिस्क्रिप्शन जारी करें", // hi
            "إصدار وصفة",          // ar
            "Emitir prescrição",   // pt
            "প্রেসক্রিপশন ইস্যু করুন", // bn
            "Выписать рецепт",     // ru
            "処方を発行",           // jp
            "ਨੁਸਖਾ ਜਾਰੀ ਕਰੋ",      // pa
            "Rezept ausstellen",   // de
            "Nerbitake resep",     // jv
            "처방 발행",           // ko
            "Émettre une ordonnance", // fr
            "ప్రిస్క్రిప్షన్ జారీ చేయండి", // te
            "प्रिस्क्रिप्शन जारी करा", // mr
            "Reçete düzenle",      // tr
            "மருந்து சீட்டை வழங்கவும்", // ta
            "Cấp đơn thuốc",       // vi
            "نسخہ جاری کریں",      // ur
            "Emettere prescrizione", // it
            "ออกใบสั่งยา",        // th
            "પ્રિસ્ક્રિપ્શન જારી કરો", // gu
            "Wystaw receptę",      // pl
            "Виписати рецепт",     // uk
            "صدور نسخه",          // fa
            "Keluarkan preskripsi", // ms
            "Emite prescripția",   // ro
            "Voorschrift uitgeven" // nl
        );

        public static LanguageText medicationName = new LanguageText(
            "Medication Name",     // en
            "Όνομα φαρμάκου",      // el
            "Nombre del medicamento", // es
            "药物名称",             // zh
            "दवा का नाम",          // hi
            "اسم الدواء",          // ar
            "Nome do medicamento", // pt
            "ওষুধের নাম",          // bn
            "Название лекарства",  // ru
            "薬の名前",             // jp
            "ਦਵਾਈ ਦਾ ਨਾਮ",         // pa
            "Medikamentenname",    // de
            "Jeneng obat",         // jv
            "약물 이름",           // ko
            "Nom du médicament",   // fr
            "ఔషధం పేరు",          // te
            "औषधाचे नाव",         // mr
            "İlaç adı",            // tr
            "மருந்தின் பெயர்",     // ta
            "Tên thuốc",           // vi
            "دوائی کا نام",        // ur
            "Nome del farmaco",    // it
            "ชื่อยา",              // th
            "દવાના નામ",          // gu
            "Nazwa leku",          // pl
            "Назва препарату",     // uk
            "نام دارو",            // fa
            "Nama ubat",           // ms
            "Numele medicamentului", // ro
            "Naam van het medicijn" // nl
        );

        public static LanguageText dosageInstructions = new LanguageText(
            "Dosage & Instructions", // en
            "Δοσολογία & οδηγίες",   // el
            "Dosis e instrucciones", // es
            "剂量和说明",            // zh
            "खुराक और निर्देश",      // hi
            "الجرعة والتعليمات",    // ar
            "Dosagem e instruções", // pt
            "ডোজ এবং নির্দেশনা",    // bn
            "Дозировка и инструкции", // ru
            "用量と指示",           // jp
            "ਖੁਰਾਕ ਅਤੇ ਹੁਕਮ",       // pa
            "Dosierung & Anweisungen", // de
            "Dosis lan pandhuan",   // jv
            "복용량 및 지침",       // ko
            "Posologie et instructions", // fr
            "మోతాదు మరియు సూచనలు", // te
            "डोस आणि सूचना",       // mr
            "Doz ve talimatlar",    // tr
            "அளவு மற்றும் வழிமுறைகள்", // ta
            "Liều lượng và hướng dẫn", // vi
            "خوراک اور ہدایات",     // ur
            "Dosaggio e istruzioni", // it
            "ขนาดยาและคำแนะนำ",    // th
            "માત્રા અને સૂચનાઓ",   // gu
            "Dawkowanie i instrukcje", // pl
            "Дозування та інструкції", // uk
            "دوز و دستورالعمل‌ها", // fa
            "Dos dan arahan",      // ms
            "Dozaj și instrucțiuni", // ro
            "Dosering en instructies" // nl
        );

        public static LanguageText releaseDate = new LanguageText(
            "Release Date",        // en
            "Ημερομηνία έκδοσης",  // el
            "Fecha de emisión",    // es
            "发布日期",             // zh
            "जारी करने की तिथि",   // hi
            "تاريخ الإصدار",       // ar
            "Data de emissão",     // pt
            "প্রকাশের তারিখ",      // bn
            "Дата выдачи",         // ru
            "発行日",              // jp
            "ਜਾਰੀ ਮਿਤੀ",          // pa
            "Ausgabedatum",        // de
            "Tanggal rilis",       // jv
            "발행일",              // ko
            "Date d'émission",     // fr
            "విడుదల తేదీ",         // te
            "जारी तारीख",          // mr
            "Yayın tarihi",        // tr
            "வெளியீட்டு தேதி",     // ta
            "Ngày phát hành",      // vi
            "اجراء کی تاریخ",      // ur
            "Data di emissione",   // it
            "วันที่ออก",           // th
            "જારી કરવાની તારીખ",  // gu
            "Data wydania",        // pl
            "Дата видачі",         // uk
            "تاریخ انتشار",        // fa
            "Tarikh keluaran",     // ms
            "Data emiterii",       // ro
            "Uitgiftedatum"        // nl
        );

        public static LanguageText editPrescription = new LanguageText(
    "Edit Prescription",    // en
    "Επεξεργασία συνταγής", // el
    "Editar receta",        // es
    "编辑处方",              // zh
    "प्रिस्क्रिप्शन संपादित करें", // hi
    "تعديل الوصفة",         // ar
    "Editar prescrição",   // pt
    "প্রেসক্রিপশন সম্পাদনা করুন", // bn
    "Редактировать рецепт", // ru
    "処方を編集",           // jp
    "ਨੁਸਖਾ ਸੰਪਾਦਿਤ ਕਰੋ",   // pa
    "Rezept bearbeiten",   // de
    "Sunting resep",       // jv
    "처방 수정",           // ko
    "Modifier l'ordonnance", // fr
    "ప్రిస్క్రిప్షన్ సవరించండి", // te
    "प्रिस्क्रिप्शन संपादित करा", // mr
    "Reçeteyi düzenle",    // tr
    "மருந்து சீட்டைத் திருத்தவும்", // ta
    "Chỉnh sửa đơn thuốc", // vi
    "نسخہ ترمیم کریں",     // ur
    "Modifica prescrizione", // it
    "แก้ไขใบสั่งยา",       // th
    "પ્રિસ્ક્રિપ્શન સંપાદિત કરો", // gu
    "Edytuj receptę",      // pl
    "Редагувати рецепт",   // uk
    "ویرایش نسخه",         // fa
    "Edit preskripsi",     // ms
    "Editează prescripția", // ro
    "Voorschrift bewerken" // nl
);


        public static LanguageText prescriptionIsActive = new LanguageText(
    "Prescription is active", // en
    "Η συνταγή είναι ενεργή", // el
    "La receta está activa",  // es
    "处方已激活",              // zh
    "प्रिस्क्रिप्शन सक्रिय है", // hi
    "الوصفة نشطة",            // ar
    "A prescrição está ativa", // pt
    "প্রেসক্রিপশন সক্রিয়",   // bn
    "Рецепт активен",         // ru
    "処方は有効です",          // jp
    "ਨੁਸਖਾ ਸਰਗਰਮ ਹੈ",       // pa
    "Rezept ist aktiv",      // de
    "Resep aktif",           // jv
    "처방이 활성 상태입니다",  // ko
    "L'ordonnance est active", // fr
    "ప్రిస్క్రిప్షన్ సక్రియంగా ఉంది", // te
    "प्रिस्क्रिप्शन सक्रिय आहे", // mr
    "Reçete aktif",          // tr
    "மருந்து சீட்டு செயலில் உள்ளது", // ta
    "Đơn thuốc đang hoạt động", // vi
    "نسخہ فعال ہے",          // ur
    "La prescrizione è attiva", // it
    "ใบสั่งยาใช้งานอยู่",     // th
    "પ્રિસ્ક્રિપ્શન સક્રિય છે", // gu
    "Recepta jest aktywna", // pl
    "Рецепт активний",      // uk
    "نسخه فعال است",        // fa
    "Preskripsi aktif",     // ms
    "Prescripția este activă", // ro
    "Voorschrift is actief" // nl
);

        public static LanguageText active = new LanguageText(
    "Active",             // en
    "Ενεργό",             // el
    "Activo",             // es
    "启用",                // zh
    "सक्रिय",             // hi
    "نشط",                // ar
    "Ativo",              // pt
    "সক্রিয়",            // bn
    "Активный",           // ru
    "有効",                // jp
    "ਸਰਗਰਮ",             // pa
    "Aktiv",              // de
    "Aktif",              // jv
    "활성",               // ko
    "Actif",              // fr
    "సక్రియ",             // te
    "सक्रिय",             // mr
    "Aktif",              // tr
    "செயலில்",            // ta
    "Hoạt động",          // vi
    "فعال",               // ur
    "Attivo",             // it
    "ใช้งาน",             // th
    "સક્રિય",             // gu
    "Aktywny",            // pl
    "Активний",           // uk
    "فعال",               // fa
    "Aktif",              // ms
    "Activ",              // ro
    "Actief"              // nl
);


        public static LanguageText inactive = new LanguageText(
    "Inactive",           // en
    "Ανενεργό",           // el
    "Inactivo",           // es
    "未启用",              // zh
    "निष्क्रिय",           // hi
    "غير نشط",            // ar
    "Inativo",            // pt
    "নিষ্ক্রিয়",          // bn
    "Неактивный",         // ru
    "無効",               // jp
    "ਗੈਰ-ਸਰਗਰਮ",         // pa
    "Inaktiv",            // de
    "Ora aktif",          // jv
    "비활성",             // ko
    "Inactif",            // fr
    "నిష్క్రియ",          // te
    "निष्क्रिय",          // mr
    "Pasif",              // tr
    "செயலற்ற",           // ta
    "Không hoạt động",    // vi
    "غیر فعال",          // ur
    "Inattivo",           // it
    "ไม่ใช้งาน",          // th
    "નિષ્ક્રિય",          // gu
    "Nieaktywny",         // pl
    "Неактивний",         // uk
    "غیرفعال",           // fa
    "Tidak aktif",        // ms
    "Inactiv",            // ro
    "Inactief"            // nl
);

        public static LanguageText prescriptionIsInactive = new LanguageText(
        "Prescription is inactive", // en
        "Η συνταγή είναι ανενεργή", // el
        "La receta está inactiva",  // es
        "处方未激活",              // zh
        "प्रिस्क्रिप्शन निष्क्रिय है", // hi
        "الوصفة غير نشطة",        // ar
        "A prescrição está inativa", // pt
        "প্রেসক্রিপশন নিষ্ক্রিয়", // bn
        "Рецепт неактивен",       // ru
        "処方は無効です",          // jp
        "ਨੁਸਖਾ ਗੈਰ-ਸਰਗਰਮ ਹੈ",   // pa
        "Rezept ist inaktiv",     // de
        "Resep tidak aktif",      // jv
        "처방이 비활성 상태입니다", // ko
        "L'ordonnance est inactive", // fr
        "ప్రిస్క్రిప్షన్ నిష్క్రియంగా ఉంది", // te
        "प्रिस्क्रिप्शन निष्क्रिय आहे", // mr
        "Reçete pasif",           // tr
        "மருந்து சீட்டு செயலற்றது", // ta
        "Đơn thuốc không hoạt động", // vi
        "نسخہ غیر فعال ہے",      // ur
        "La prescrizione è inattiva", // it
        "ใบสั่งยาไม่ใช้งาน",      // th
        "પ્રિસ્ક્રિપ્શન નિષ્ક્રિય છે", // gu
        "Recepta jest nieaktywna", // pl
        "Рецепт неактивний",      // uk
        "نسخه غیرفعال است",      // fa
        "Preskripsi tidak aktif", // ms
        "Prescripția este inactivă", // ro
        "Voorschrift is inactief" // nl
    );
        public static LanguageText activePrescription = new LanguageText(
        "Active prescription", // en
        "Ενεργή συνταγή",      // el
        "Receta activa",       // es
        "有效处方",             // zh
        "सक्रिय प्रिस्क्रिप्शन", // hi
        "وصفة نشطة",           // ar
        "Prescrição ativa",    // pt
        "সক্রিয় প্রেসক্রিপশন", // bn
        "Активный рецепт",     // ru
        "有効な処方",           // jp
        "ਸਰਗਰਮ ਨੁਸਖਾ",        // pa
        "Aktives Rezept",      // de
        "Resep aktif",         // jv
        "활성 처방",           // ko
        "Ordonnance active",   // fr
        "సక్రియ ప్రిస్క్రిప్షన్", // te
        "सक्रिय प्रिस्क्रिप्शन", // mr
        "Aktif reçete",        // tr
        "செயலில் உள்ள மருந்து சீட்டு", // ta
        "Đơn thuốc hoạt động", // vi
        "فعال نسخہ",           // ur
        "Prescrizione attiva", // it
        "ใบสั่งยาที่ใช้งานอยู่", // th
        "સક્રિય પ્રિસ્ક્રિપ્શન", // gu
        "Aktywna recepta",     // pl
        "Активний рецепт",     // uk
        "نسخه فعال",           // fa
        "Preskripsi aktif",    // ms
        "Prescripție activă",  // ro
        "Actief voorschrift"   // nl
    );

        public static LanguageText inactivePrescription = new LanguageText(
            "Inactive prescription", // en
            "Ανενεργή συνταγή",      // el
            "Receta inactiva",       // es
            "无效处方",              // zh
            "निष्क्रिय प्रिस्क्रिप्शन", // hi
            "وصفة غير نشطة",        // ar
            "Prescrição inativa",   // pt
            "নিষ্ক্রিয় প্রেসক্রিপশন", // bn
            "Неактивный рецепт",    // ru
            "無効な処方",            // jp
            "ਗੈਰ-ਸਰਗਰਮ ਨੁਸਖਾ",    // pa
            "Inaktives Rezept",     // de
            "Resep tidak aktif",    // jv
            "비활성 처방",          // ko
            "Ordonnance inactive",  // fr
            "నిష్క్రియ ప్రిస్క్రిప్షన్", // te
            "निष्क्रिय प्रिस्क्रिप्शन", // mr
            "Pasif reçete",         // tr
            "செயலற்ற மருந்து சீட்டு", // ta
            "Đơn thuốc không hoạt động", // vi
            "غیر فعال نسخہ",        // ur
            "Prescrizione inattiva", // it
            "ใบสั่งยาที่ไม่ใช้งาน", // th
            "નિષ્ક્રિય પ્રિસ્ક્રિપ્શન", // gu
            "Nieaktywna recepta",   // pl
            "Неактивний рецепт",    // uk
            "نسخه غیرفعال",         // fa
            "Preskripsi tidak aktif", // ms
            "Prescripție inactivă", // ro
            "Inactief voorschrift"  // nl
        );

        public static LanguageText deleteDiagnosisConfirm = new LanguageText(
   "ARE YOU SURE YOU WANT TO DELETE THIS DIAGNOSIS?",  // en
   "ΕΙΣΤΕ ΣΙΓΟΥΡΟΙ ΟΤΙ ΘΕΛΕΤΕ ΝΑ ΔΙΑΓΡΑΨΕΤΕ ΑΥΤΗ ΤΗ ΔΙΑΓΝΩΣΗ;",  // el
   "¿ESTÁ SEGURO DE QUE DESEA ELIMINAR ESTE DIAGNÓSTICO?",  // es
   "您确定要删除此诊断吗？",  // zh
   "क्या आप सुनिश्चित हैं कि आप इस निदान को हटाना चाहते हैं?",  // hi
   "هل أنت متأكد أنك تريد حذف هذا التشخيص؟",  // ar
   "TEM CERTEZA DE QUE DESEJA EXCLUIR ESTE DIAGNÓSTICO?",  // pt
   "আপনি কি নিশ্চিত যে আপনি এই নির্ণয়টি মুছে ফেলতে চান?",  // bn
   "ВЫ УВЕРЕНЫ, ЧТО ХОТИТЕ УДАЛИТЬ ЭТОТ ДИАГНОЗ?",  // ru
   "この診断を削除してもよろしいですか？",  // jp
   "ਕੀ ਤੁਸੀਂ ਯਕੀਨੀ ਹੋ ਕਿ ਤੁਸੀਂ ਇਸ ਨਿਦਾਨ ਨੂੰ ਮਿਟਾਉਣਾ ਚਾਹੁੰਦੇ ਹੋ?",  // pa
   "SIND SIE SICHER, DASS SIE DIESE DIAGNOSE LÖSCHEN MÖCHTEN?",  // de
   "APA ANDA YAKIN INGIN MENGHAPUS DIAGNOSIS INI?",  // jv
   "이 진단을 삭제하시겠습니까?",  // ko
   "ÊTES-VOUS SÛR DE VOULOIR SUPPRIMER CE DIAGNOSTIC ?",  // fr
   "మీరు ఈ నిర్ధారణను తొలగించాలనుకుంటున్నారా?",  // te
   "तुम्हाला खात्री आहे की तुम्ही हे निदान हटवू इच्छिता?",  // mr
   "BU TEŞHİSİ SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ?",  // tr
   "இந்த நோயறிதலை நீக்க விரும்புகிறீர்களா?",  // ta
   "BẠN CÓ CHẮC CHẮN MUỐN XÓA CHẨN ĐOÁN NÀY KHÔNG?",  // vi
   "کیا آپ واقعی اس تشخیص کو حذف کرنا چاہتے ہیں؟",  // ur
   "SEI SICURO DI VOLER ELIMINARE QUESTA DIAGNOSI?",  // it
   "คุณแน่ใจหรือไม่ว่าต้องการลบการวินิจฉัยนี้?",  // th
   "શું તમે ખરેખર આ નિદાન કાઢી નાખવા માંગો છો?",  // gu
   "CZY NA PEWNO CHCESZ USUNĄĆ TĘ DIAGNOZĘ?",  // pl
   "ВИ ВПЕВНЕНІ, ЩО ХОЧЕТЕ ВИДАЛИТИ ЦЕЙ ДІАГНОЗ?",  // uk
   "آیا مطمئن هستید که می‌خواهید این تشخیص را حذف کنید؟",  // fa
   "ADAKAH ANDA PASTI MAHU MEMADAM DIAGNOSIS INI?",  // ms
   "EȘTI SIGUR CĂ VREI SĂ ȘTERGI ACEST DIAGNOSTIC?",  // ro
   "WEET U ZEKER DAT U DEZE DIAGNOSE WILT VERWIJDEREN?"  // nl
);

        public static LanguageText actionCannotBeUndone = new LanguageText(
           "This action cannot be undone.",  // en
           "Αυτή η ενέργεια δεν μπορεί να αναιρεθεί.",  // el
           "Esta acción no se puede deshacer.",  // es
           "此操作无法撤销。",  // zh
           "इस क्रिया को पूर्ववत नहीं किया जा सकता।",  // hi
           "لا يمكن التراجع عن هذا الإجراء.",  // ar
           "Esta ação não pode ser desfeita.",  // pt
           "এই ক্রিয়াটি পূর্বাবস্থায় ফেরানো যাবে না।",  // bn
           "Это действие нельзя отменить.",  // ru
           "この操作は元に戻せません。",  // jp
           "ਇਸ ਕਾਰਵਾਈ ਨੂੰ ਵਾਪਸ ਨਹੀਂ ਕੀਤਾ ਜਾ ਸਕਦਾ।",  // pa
           "Diese Aktion kann nicht rückgängig gemacht werden.",  // de
           "Tindakan ini tidak dapat dibatalkan.",  // jv
           "이 작업은 취소할 수 없습니다.",  // ko
           "Cette action est irréversible.",  // fr
           "ఈ చర్యను తిరిగి మార్చలేము.",  // te
           "ही कृती पूर्ववत केली जाऊ शकत नाही.",  // mr
           "Bu işlem geri alınamaz.",  // tr
           "இந்த செயலை மீண்டும் மாற்ற முடியாது.",  // ta
           "Hành động này không thể hoàn tác.",  // vi
           "یہ عمل واپس نہیں لیا جا سکتا۔",  // ur
           "Questa azione non può essere annullata.",  // it
           "การดำเนินการนี้ไม่สามารถย้อนกลับได้",  // th
           "આ ક્રિયા પાછી ફરી શકાતી નથી.",  // gu
           "Tej operacji nie można cofnąć.",  // pl
           "Цю дію не можна скасувати.",  // uk
           "این عمل قابل بازگشت نیست.",  // fa
           "Tindakan ini tidak boleh dibuat asal.",  // ms
           "Această acțiune nu poate fi anulată.",  // ro
           "Deze actie kan niet ongedaan worden gemaakt."  // nl
        );

        public static LanguageText deleteText = new LanguageText(
           "Delete",  // en
           "Διαγραφή",  // el
           "Eliminar",  // es
           "删除",  // zh
           "हटाएं",  // hi
           "حذف",  // ar
           "Excluir",  // pt
           "মুছুন",  // bn
           "Удалить",  // ru
           "削除",  // jp
           "ਮਿਟਾਓ",  // pa
           "Löschen",  // de
           "Hapus",  // jv
           "삭제",  // ko
           "Supprimer",  // fr
           "తొలగించు",  // te
           "हटवा",  // mr
           "Sil",  // tr
           "நீக்கு",  // ta
           "Xóa",  // vi
           "حذف کریں",  // ur
           "Elimina",  // it
           "ลบ",  // th
           "કાઢી નાખો",  // gu
           "Usuń",  // pl
           "Видалити",  // uk
           "حذف",  // fa
           "Padam",  // ms
           "Șterge",  // ro
           "Verwijderen"  // nl
        );

        public static LanguageText deletePrescription = new LanguageText(
   "Delete Prescription",  // en
   "Διαγραφή Συνταγής",  // el
   "Eliminar receta",  // es
   "删除处方",  // zh
   "प्रिस्क्रिप्शन हटाएं",  // hi
   "حذف الوصفة الطبية",  // ar
   "Excluir prescrição",  // pt
   "প্রেসক্রিপশন মুছুন",  // bn
   "Удалить рецепт",  // ru
   "処方箋を削除",  // jp
   "ਨੁਸਖਾ ਮਿਟਾਓ",  // pa
   "Rezept löschen",  // de
   "Hapus resep",  // jv
   "처방전 삭제",  // ko
   "Supprimer l'ordonnance",  // fr
   "ప్రిస్క్రిప్షన్ తొలగించు",  // te
   "प्रिस्क्रिप्शन हटवा",  // mr
   "Reçeteyi sil",  // tr
   "மருந்து சீட்டை நீக்கு",  // ta
   "Xóa đơn thuốc",  // vi
   "نسخہ حذف کریں",  // ur
   "Elimina prescrizione",  // it
   "ลบใบสั่งยา",  // th
   "પ્રિસ્ક્રિપ્શન કાઢી નાખો",  // gu
   "Usuń receptę",  // pl
   "Видалити рецепт",  // uk
   "حذف نسخه",  // fa
   "Padam preskripsi",  // ms
   "Șterge rețeta",  // ro
   "Recept verwijderen"  // nl
);

        public static LanguageText deleteDiagnosis = new LanguageText(
           "Delete Diagnosis",  // en
           "Διαγραφή Διάγνωσης",  // el
           "Eliminar diagnóstico",  // es
           "删除诊断",  // zh
           "निदान हटाएं",  // hi
           "حذف التشخيص",  // ar
           "Excluir diagnóstico",  // pt
           "নির্ণয় মুছুন",  // bn
           "Удалить диагноз",  // ru
           "診断を削除",  // jp
           "ਨਿਦਾਨ ਮਿਟਾਓ",  // pa
           "Diagnose löschen",  // de
           "Hapus diagnosis",  // jv
           "진단 삭제",  // ko
           "Supprimer le diagnostic",  // fr
           "నిర్ధారణ తొలగించు",  // te
           "निदान हटवा",  // mr
           "Teşhisi sil",  // tr
           "நோயறிதலை நீக்கு",  // ta
           "Xóa chẩn đoán",  // vi
           "تشخیص حذف کریں",  // ur
           "Elimina diagnosi",  // it
           "ลบการวินิจฉัย",  // th
           "નિદાન કાઢી નાખો",  // gu
           "Usuń diagnozę",  // pl
           "Видалити діагноз",  // uk
           "حذف تشخیص",  // fa
           "Padam diagnosis",  // ms
           "Șterge diagnosticul",  // ro
           "Diagnose verwijderen"  // nl
        );

        public static LanguageText diagnosisDetails = new LanguageText(
           "DIAGNOSIS DETAILS",  // en
           "ΛΕΠΤΟΜΕΡΕΙΕΣ ΔΙΑΓΝΩΣΗΣ",  // el
           "DETALLES DEL DIAGNÓSTICO",  // es
           "诊断详情",  // zh
           "निदान विवरण",  // hi
           "تفاصيل التشخيص",  // ar
           "DETALHES DO DIAGNÓSTICO",  // pt
           "নির্ণয়ের বিস্তারিত",  // bn
           "ДЕТАЛИ ДИАГНОЗА",  // ru
           "診断の詳細",  // jp
           "ਨਿਦਾਨ ਵੇਰਵੇ",  // pa
           "DIAGNOSEDETAILS",  // de
           "Rincian diagnosis",  // jv
           "진단 세부 정보",  // ko
           "DÉTAILS DU DIAGNOSTIC",  // fr
           "నిర్ధారణ వివరాలు",  // te
           "निदान तपशील",  // mr
           "TEŞHİS DETAYLARI",  // tr
           "நோயறிதல் விவரங்கள்",  // ta
           "CHI TIẾT CHẨN ĐOÁN",  // vi
           "تشخیص کی تفصیلات",  // ur
           "DETTAGLI DELLA DIAGNOSI",  // it
           "รายละเอียดการวินิจฉัย",  // th
           "નિદાનની વિગતો",  // gu
           "SZCZEGÓŁY DIAGNOZY",  // pl
           "ДЕТАЛІ ДІАГНОЗУ",  // uk
           "جزئیات تشخیص",  // fa
           "BUTIRAN DIAGNOSIS",  // ms
           "DETALII DIAGNOSTIC",  // ro
           "DIAGNOSEDETAILS"  // nl
        );

        public static LanguageText clinicalDiagnosis = new LanguageText(
           "Clinical Diagnosis",  // en
           "Κλινική Διάγνωση",  // el
           "Diagnóstico clínico",  // es
           "临床诊断",  // zh
           "नैदानिक निदान",  // hi
           "التشخيص السريري",  // ar
           "Diagnóstico clínico",  // pt
           "ক্লিনিক্যাল নির্ণয়",  // bn
           "Клинический диагноз",  // ru
           "臨床診断",  // jp
           "ਕਲੀਨਿਕਲ ਨਿਦਾਨ",  // pa
           "Klinische Diagnose",  // de
           "Diagnosis klinis",  // jv
           "임상 진단",  // ko
           "Diagnostic clinique",  // fr
           "క్లినికల్ నిర్ధారణ",  // te
           "क्लिनिकल निदान",  // mr
           "Klinik teşhis",  // tr
           "மருத்துவ நோயறிதல்",  // ta
           "Chẩn đoán lâm sàng",  // vi
           "کلینیکل تشخیص",  // ur
           "Diagnosi clinica",  // it
           "การวินิจฉัยทางคลินิก",  // th
           "ક્લિનિકલ નિદાન",  // gu
           "Diagnoza kliniczna",  // pl
           "Клінічний діагноз",  // uk
           "تشخیص بالینی",  // fa
           "Diagnosis klinikal",  // ms
           "Diagnostic clinic",  // ro
           "Klinische diagnose"  // nl
        );

        public static LanguageText conditionDiagnosis = new LanguageText(
           "Condition / Diagnosis",  // en
           "Κατάσταση / Διάγνωση",  // el
           "Condición / Diagnóstico",  // es
           "状况 / 诊断",  // zh
           "स्थिति / निदान",  // hi
           "الحالة / التشخيص",  // ar
           "Condição / Diagnóstico",  // pt
           "অবস্থা / নির্ণয়",  // bn
           "Состояние / Диагноз",  // ru
           "状態 / 診断",  // jp
           "ਹਾਲਤ / ਨਿਦਾਨ",  // pa
           "Zustand / Diagnose",  // de
           "Kondisi / Diagnosis",  // jv
           "상태 / 진단",  // ko
           "État / Diagnostic",  // fr
           "స్థితి / నిర్ధారణ",  // te
           "स्थिती / निदान",  // mr
           "Durum / Teşhis",  // tr
           "நிலை / நோயறிதல்",  // ta
           "Tình trạng / Chẩn đoán",  // vi
           "حالت / تشخیص",  // ur
           "Condizione / Diagnosi",  // it
           "สภาพ / การวินิจฉัย",  // th
           "સ્થિતિ / નિદાન",  // gu
           "Stan / Diagnoza",  // pl
           "Стан / Діагноз",  // uk
           "وضعیت / تشخیص",  // fa
           "Keadaan / Diagnosis",  // ms
           "Condiție / Diagnostic",  // ro
           "Aandoening / Diagnose"  // nl
        );

        public static LanguageText deletePrescriptionConfirm = new LanguageText(
           "ARE YOU SURE YOU WANT TO DELETE THIS PRESCRIPTION?",  // en
           "ΕΙΣΤΕ ΣΙΓΟΥΡΟΙ ΟΤΙ ΘΕΛΕΤΕ ΝΑ ΔΙΑΓΡΑΨΕΤΕ ΑΥΤΗ ΤΗ ΣΥΝΤΑΓΗ;",  // el
           "¿ESTÁ SEGURO DE QUE DESEA ELIMINAR ESTA RECETA?",  // es
           "您确定要删除此处方吗？",  // zh
           "क्या आप सुनिश्चित हैं कि आप इस प्रिस्क्रिप्शन को हटाना चाहते हैं?",  // hi
           "هل أنت متأكد أنك تريد حذف هذه الوصفة الطبية؟",  // ar
           "TEM CERTEZA DE QUE DESEJA EXCLUIR ESTA PRESCRIÇÃO?",  // pt
           "আপনি কি নিশ্চিত যে আপনি এই প্রেসক্রিপশনটি মুছে ফেলতে চান?",  // bn
           "ВЫ УВЕРЕНЫ, ЧТО ХОТИТЕ УДАЛИТЬ ЭТОТ РЕЦЕПТ?",  // ru
           "この処方箋を削除してもよろしいですか？",  // jp
           "ਕੀ ਤੁਸੀਂ ਯਕੀਨੀ ਹੋ ਕਿ ਤੁਸੀਂ ਇਸ ਨੁਸਖੇ ਨੂੰ ਮਿਟਾਉਣਾ ਚਾਹੁੰਦੇ ਹੋ?",  // pa
           "SIND SIE SICHER, DASS SIE DIESES REZEPT LÖSCHEN MÖCHTEN?",  // de
           "APA ANDA YAKIN INGIN MENGHAPUS RESEP INI?",  // jv
           "이 처방전을 삭제하시겠습니까?",  // ko
           "ÊTES-VOUS SÛR DE VOULOIR SUPPRIMER CETTE ORDONNANCE ?",  // fr
           "మీరు ఈ ప్రిస్క్రిప్షన్‌ను తొలగించాలనుకుంటున్నారా?",  // te
           "तुम्हाला खात्री आहे की तुम्ही हे प्रिस्क्रिप्शन हटवू इच्छिता?",  // mr
           "BU REÇETEYİ SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ?",  // tr
           "இந்த மருந்து சீட்டை நீக்க விரும்புகிறீர்களா?",  // ta
           "BẠN CÓ CHẮC CHẮN MUỐN XÓA ĐƠN THUỐC NÀY KHÔNG?",  // vi
           "کیا آپ واقعی اس نسخے کو حذف کرنا چاہتے ہیں؟",  // ur
           "SEI SICURO DI VOLER ELIMINARE QUESTA PRESCRIZIONE?",  // it
           "คุณแน่ใจหรือไม่ว่าต้องการลบใบสั่งยานี้?",  // th
           "શું તમે ખરેખર આ પ્રિસ્ક્રિપ્શન કાઢી નાખવા માંગો છો?",  // gu
           "CZY NA PEWNO CHCESZ USUNĄĆ TĘ RECEPTĘ?",  // pl
           "ВИ ВПЕВНЕНІ, ЩО ХОЧЕТЕ ВИДАЛИТИ ЦЕЙ РЕЦЕПТ?",  // uk
           "آیا مطمئن هستید که می‌خواهید این نسخه را حذف کنید؟",  // fa
           "ADAKAH ANDA PASTI MAHU MEMADAM PRESKRIPSI INI?",  // ms
           "EȘTI SIGUR CĂ VREI SĂ ȘTERGI ACEASTĂ REȚETĂ?",  // ro
           "WEET U ZEKER DAT U DIT RECEPT WILT VERWIJDEREN?"  // nl
        );

        public static LanguageText deleteAppointment = new LanguageText(
   "Delete Appointment",  // en
   "Διαγραφή Ραντεβού",  // el
   "Eliminar cita",  // es
   "删除预约",  // zh
   "अपॉइंटमेंट हटाएं",  // hi
   "حذف الموعد",  // ar
   "Excluir consulta",  // pt
   "অ্যাপয়েন্টমেন্ট মুছুন",  // bn
   "Удалить запись",  // ru
   "予約を削除",  // jp
   "ਮੁਲਾਕਾਤ ਮਿਟਾਓ",  // pa
   "Termin löschen",  // de
   "Busak janji",  // jv
   "예약 삭제",  // ko
   "Supprimer le rendez-vous",  // fr
   "అపాయింట్‌మెంట్ తొలగించండి",  // te
   "अपॉइंटमेंट हटवा",  // mr
   "Randevuyu sil",  // tr
   "நியமனத்தை நீக்கு",  // ta
   "Xóa cuộc hẹn",  // vi
   "اپائنٹمنٹ حذف کریں",  // ur
   "Elimina appuntamento",  // it
   "ลบการนัดหมาย",  // th
   "અપોઇન્ટમેન્ટ કાઢી નાખો",  // gu
   "Usuń wizytę",  // pl
   "Видалити запис",  // uk
   "حذف نوبت",  // fa
   "Padam janji temu",  // ms
   "Șterge programarea",  // ro
   "Afspraak verwijderen"  // nl
);

        public static LanguageText deletePatient = new LanguageText(
           "Delete Patient",  // en
           "Διαγραφή Ασθενούς",  // el
           "Eliminar paciente",  // es
           "删除患者",  // zh
           "रोगी हटाएं",  // hi
           "حذف المريض",  // ar
           "Excluir paciente",  // pt
           "রোগী মুছুন",  // bn
           "Удалить пациента",  // ru
           "患者を削除",  // jp
           "ਮਰੀਜ਼ ਮਿਟਾਓ",  // pa
           "Patient löschen",  // de
           "Busak pasien",  // jv
           "환자 삭제",  // ko
           "Supprimer le patient",  // fr
           "రోగిని తొలగించండి",  // te
           "रुग्ण हटवा",  // mr
           "Hastayı sil",  // tr
           "நோயாளியை நீக்கு",  // ta
           "Xóa bệnh nhân",  // vi
           "مریض حذف کریں",  // ur
           "Elimina paziente",  // it
           "ลบผู้ป่วย",  // th
           "દર્દી કાઢી નાખો",  // gu
           "Usuń pacjenta",  // pl
           "Видалити пацієнта",  // uk
           "حذف بیمار",  // fa
           "Padam pesakit",  // ms
           "Șterge pacientul",  // ro
           "Patiënt verwijderen"  // nl
        );

        public static LanguageText confirmDeleteAppointment = new LanguageText(
           "ARE YOU SURE YOU WANT TO DELETE THIS APPOINTMENT?",  // en
           "ΕΙΣΤΕ ΣΙΓΟΥΡΟΙ ΟΤΙ ΘΕΛΕΤΕ ΝΑ ΔΙΑΓΡΑΨΕΤΕ ΑΥΤΟ ΤΟ ΡΑΝΤΕΒΟΥ;",  // el
           "¿ESTÁ SEGURO DE QUE DESEA ELIMINAR ESTA CITA?",  // es
           "您确定要删除此预约吗？",  // zh
           "क्या आप वाकई इस अपॉइंटमेंट को हटाना चाहते हैं?",  // hi
           "هل أنت متأكد أنك تريد حذف هذا الموعد؟",  // ar
           "Tem certeza de que deseja excluir esta consulta?",  // pt
           "আপনি কি নিশ্চিত যে আপনি এই অ্যাপয়েন্টমেন্টটি মুছতে চান?",  // bn
           "Вы уверены, что хотите удалить эту запись?",  // ru
           "この予約を削除してもよろしいですか？",  // jp
           "ਕੀ ਤੁਸੀਂ ਯਕੀਨਨ ਇਹ ਮੁਲਾਕਾਤ ਮਿਟਾਉਣਾ ਚਾਹੁੰਦੇ ਹੋ?",  // pa
           "Sind Sie sicher, dass Sie diesen Termin löschen möchten?",  // de
           "Apa sampeyan yakin arep mbusak janji iki?",  // jv
           "이 예약을 삭제하시겠습니까?",  // ko
           "Êtes-vous sûr de vouloir supprimer ce rendez-vous ?",  // fr
           "మీరు ఈ అపాయింట్‌మెంట్‌ను తొలగించాలనుకుంటున్నారా?",  // te
           "आपण ही अपॉइंटमेंट हटवू इच्छिता का?",  // mr
           "Bu randevuyu silmek istediğinizden emin misiniz?",  // tr
           "இந்த நியமனத்தை நீக்க விரும்புகிறீர்களா?",  // ta
           "Bạn có chắc muốn xóa cuộc hẹn này không?",  // vi
           "کیا آپ واقعی اس اپائنٹمنٹ کو حذف کرنا چاہتے ہیں؟",  // ur
           "Sei sicuro di voler eliminare questo appuntamento?",  // it
           "คุณแน่ใจหรือไม่ว่าต้องการลบการนัดหมายนี้?",  // th
           "શું તમે આ અપોઇન્ટમેન્ટ કાઢી નાખવા માંગો છો?",  // gu
           "Czy na pewno chcesz usunąć tę wizytę?",  // pl
           "Ви впевнені, що хочете видалити цей запис?",  // uk
           "آیا مطمئن هستید که می‌خواهید این نوبت را حذف کنید؟",  // fa
           "Adakah anda pasti mahu memadam janji temu ini?",  // ms
           "Sigur doriți să ștergeți această programare?",  // ro
           "Weet je zeker dat je deze afspraak wilt verwijderen?"  // nl
        );

        public static LanguageText confirmDeletePatient = new LanguageText(
           "ARE YOU SURE YOU WANT TO DELETE THIS PATIENT?",  // en
           "ΕΙΣΤΕ ΣΙΓΟΥΡΟΙ ΟΤΙ ΘΕΛΕΤΕ ΝΑ ΔΙΑΓΡΑΨΕΤΕ ΑΥΤΟΝ ΤΟΝ ΑΣΘΕΝΗ;",  // el
           "¿ESTÁ SEGURO DE QUE DESEA ELIMINAR ESTE PACIENTE?",  // es
           "您确定要删除此患者吗？",  // zh
           "क्या आप वाकई इस रोगी को हटाना चाहते हैं?",  // hi
           "هل أنت متأكد أنك تريد حذف هذا المريض؟",  // ar
           "Tem certeza de que deseja excluir este paciente?",  // pt
           "আপনি কি নিশ্চিত যে আপনি এই রোগীটিকে মুছতে চান?",  // bn
           "Вы уверены, что хотите удалить этого пациента?",  // ru
           "この患者を削除してもよろしいですか？",  // jp
           "ਕੀ ਤੁਸੀਂ ਯਕੀਨਨ ਇਸ ਮਰੀਜ਼ ਨੂੰ ਮਿਟਾਉਣਾ ਚਾਹੁੰਦੇ ਹੋ?",  // pa
           "Sind Sie sicher, dass Sie diesen Patienten löschen möchten?",  // de
           "Apa sampeyan yakin arep mbusak pasien iki?",  // jv
           "이 환자를 삭제하시겠습니까?",  // ko
           "Êtes-vous sûr de vouloir supprimer ce patient ?",  // fr
           "మీరు ఈ రోగిని తొలగించాలనుకుంటున్నారా?",  // te
           "आपण हा रुग्ण हटवू इच्छिता का?",  // mr
           "Bu hastayı silmek istediğinizden emin misiniz?",  // tr
           "இந்த நோயாளியை நீக்க விரும்புகிறீர்களா?",  // ta
           "Bạn có chắc muốn xóa bệnh nhân này không?",  // vi
           "کیا آپ واقعی اس مریض کو حذف کرنا چاہتے ہیں؟",  // ur
           "Sei sicuro di voler eliminare questo paziente?",  // it
           "คุณแน่ใจหรือไม่ว่าต้องการลบผู้ป่วยนี้?",  // th
           "શું તમે આ દર્દીને કાઢી નાખવા માંગો છો?",  // gu
           "Czy na pewno chcesz usunąć tego pacjenta?",  // pl
           "Ви впевнені, що хочете видалити цього пацієнта?",  // uk
           "آیا مطمئن هستید که می‌خواهید این بیمار را حذف کنید؟",  // fa
           "Adakah anda pasti mahu memadam pesakit ini?",  // ms
           "Sigur doriți să ștergeți acest pacient?",  // ro
           "Weet je zeker dat je deze patiënt wilt verwijderen?"  // nl
        );



        public static LanguageText patientRecords = new LanguageText(
       "PATIENT RECORDS",  // en
       "ΑΡΧΕΙΑ ΑΣΘΕΝΩΝ",  // el
       "REGISTROS DE PACIENTES",  // es
       "患者记录",  // zh
       "रोगी अभिलेख",  // hi
       "سجلات المرضى",  // ar
       "REGISTROS DE PACIENTES",  // pt
       "রোগীর নথি",  // bn
       "МЕДИЦИНСКИЕ ЗАПИСИ ПАЦИЕНТА",  // ru
       "患者記録",  // jp
       "ਮਰੀਜ਼ ਦੇ ਰਿਕਾਰਡ",  // pa
       "PATIENTENAKTEN",  // de
       "Catatan pasien",  // jv
       "환자 기록",  // ko
       "DOSSIERS PATIENTS",  // fr
       "రోగి రికార్డులు",  // te
       "रुग्ण नोंदी",  // mr
       "HASTA KAYITLARI",  // tr
       "நோயாளர் பதிவுகள்",  // ta
       "HỒ SƠ BỆNH NHÂN",  // vi
       "مریض کے ریکارڈ",  // ur
       "CARTELLE PAZIENTE",  // it
       "บันทึกผู้ป่วย",  // th
       "રોગીના રેકોર્ડ્સ",  // gu
       "DOKUMENTACJA PACJENTA",  // pl
       "МЕДИЧНІ ЗАПИСИ ПАЦІЄНТА",  // uk
       "سوابق بیمار",  // fa
       "Rekod pesakit",  // ms
       "DOSARE PACIENT",  // ro
       "PATIËNTDOSSIERS"  // nl
    );

        public static LanguageText medicalHistoryAllergies = new LanguageText(
           "Medical History & Allergies",  // en
           "Ιατρικό Ιστορικό & Αλλεργίες",  // el
           "Historial médico y alergias",  // es
           "病史和过敏",  // zh
           "चिकित्सा इतिहास और एलर्जी",  // hi
           "التاريخ الطبي والحساسية",  // ar
           "Histórico médico e alergias",  // pt
           "চিকিৎসা ইতিহাস ও অ্যালার্জি",  // bn
           "Медицинская история и аллергии",  // ru
           "病歴とアレルギー",  // jp
           "ਮੈਡੀਕਲ ਇਤਿਹਾਸ ਅਤੇ ਐਲਰਜੀਆਂ",  // pa
           "Krankengeschichte & Allergien",  // de
           "Riwayat medis & alergi",  // jv
           "병력 및 알레르기",  // ko
           "Antécédents médicaux et allergies",  // fr
           "వైద్య చరిత్ర & అలర్జీలు",  // te
           "वैद्यकीय इतिहास व अ‍ॅलर्जी",  // mr
           "Tıbbi geçmiş ve alerjiler",  // tr
           "மருத்துவ வரலாறு & அலர்ஜிகள்",  // ta
           "Tiền sử bệnh & dị ứng",  // vi
           "طبی تاریخ اور الرجیز",  // ur
           "Storia medica e allergie",  // it
           "ประวัติทางการแพทย์และอาการแพ้",  // th
           "વૈદ્યકીય ઇતિહાસ અને એલર્જી",  // gu
           "Historia medyczna i alergie",  // pl
           "Медична історія та алергії",  // uk
           "سابقه پزشکی و آلرژی‌ها",  // fa
           "Sejarah perubatan & alahan",  // ms
           "Istoric medical și alergii",  // ro
           "Medische geschiedenis & allergieën"  // nl
        );

        public static LanguageText generalMedicalHistory = new LanguageText(
           "General Medical History",  // en
           "Γενικό Ιατρικό Ιστορικό",  // el
           "Historial médico general",  // es
           "一般病史",  // zh
           "सामान्य चिकित्सा इतिहास",  // hi
           "التاريخ الطبي العام",  // ar
           "Histórico médico geral",  // pt
           "সাধারণ চিকিৎসা ইতিহাস",  // bn
           "Общая медицинская история",  // ru
           "一般的な病歴",  // jp
           "ਸਧਾਰਣ ਮੈਡੀਕਲ ਇਤਿਹਾਸ",  // pa
           "Allgemeine Krankengeschichte",  // de
           "Riwayat medis umum",  // jv
           "일반 병력",  // ko
           "Antécédents médicaux généraux",  // fr
           "సాధారణ వైద్య చరిత్ర",  // te
           "सामान्य वैद्यकीय इतिहास",  // mr
           "Genel tıbbi geçmiş",  // tr
           "பொது மருத்துவ வரலாறு",  // ta
           "Tiền sử bệnh chung",  // vi
           "عمومی طبی تاریخ",  // ur
           "Storia medica generale",  // it
           "ประวัติทางการแพทย์ทั่วไป",  // th
           "સામાન્ય વૈદ્યકીય ઇતિહાસ",  // gu
           "Ogólna historia medyczna",  // pl
           "Загальна медична історія",  // uk
           "سابقه پزشکی عمومی",  // fa
           "Sejarah perubatan umum",  // ms
           "Istoric medical general",  // ro
           "Algemene medische geschiedenis"  // nl
        );

        public static LanguageText allergiesIntolerances = new LanguageText(
           "Allergies & Intolerances",  // en
           "Αλλεργίες & Δυσανεξίες",  // el
           "Alergias e intolerancias",  // es
           "过敏和不耐受",  // zh
           "एलर्जी और असहिष्णुता",  // hi
           "الحساسية وعدم التحمل",  // ar
           "Alergias e intolerâncias",  // pt
           "অ্যালার্জি ও অসহিষ্ণুতা",  // bn
           "Аллергии и непереносимости",  // ru
           "アレルギーと不耐性",  // jp
           "ਐਲਰਜੀਆਂ ਅਤੇ ਅਸਹਿਣਸ਼ੀਲਤਾ",  // pa
           "Allergien & Unverträglichkeiten",  // de
           "Alergi & intoleransi",  // jv
           "알레르기 및 불내성",  // ko
           "Allergies et intolérances",  // fr
           "అలర్జీలు & అసహనాలు",  // te
           "अ‍ॅलर्जी व असहिष्णुता",  // mr
           "Alerjiler ve intoleranslar",  // tr
           "அலர்ஜிகள் & சகிப்புத்தன்மையின்மை",  // ta
           "Dị ứng và không dung nạp",  // vi
           "الرجی اور عدم برداشت",  // ur
           "Allergie e intolleranze",  // it
           "อาการแพ้และการไม่ทนต่อ",  // th
           "એલર્જી અને અસહિષ્ણુતા",  // gu
           "Alergie i nietolerancje",  // pl
           "Алергії та непереносимості",  // uk
           "آلرژی‌ها و عدم تحمل",  // fa
           "Alahan & intoleransi",  // ms
           "Alergii și intoleranțe",  // ro
           "Allergieën en intoleranties"  // nl
        );

        public static LanguageText allergyWarning = new LanguageText(
           "Ensure all known drug allergies are updated to prevent prescription errors.",  // en
           "Βεβαιωθείτε ότι όλες οι γνωστές αλλεργίες σε φάρμακα είναι ενημερωμένες για την αποφυγή λαθών στη συνταγογράφηση.",  // el
           "Asegúrese de que todas las alergias a medicamentos estén actualizadas para evitar errores de prescripción.",  // es
           "确保所有已知的药物过敏信息已更新，以防止处方错误。",  // zh
           "सुनिश्चित करें कि सभी ज्ञात दवा एलर्जी अद्यतन हैं ताकि प्रिस्क्रिप्शन त्रुटियों से बचा जा सके।",  // hi
           "تأكد من تحديث جميع الحساسية المعروفة للأدوية لمنع أخطاء الوصفات الطبية.",  // ar
           "Certifique-se de que todas as alergias a medicamentos estejam atualizadas para evitar erros de prescrição.",  // pt
           "নিশ্চিত করুন যে সব পরিচিত ওষুধের অ্যালার্জি আপডেট করা হয়েছে যাতে প্রেসক্রিপশন ত্রুটি এড়ানো যায়।",  // bn
           "Убедитесь, что все известные аллергии на лекарства обновлены, чтобы избежать ошибок в рецептах.",  // ru
           "既知の薬物アレルギーがすべて更新されていることを確認し、処方ミスを防いでください。",  // jp
           "ਯਕੀਨੀ ਬਣਾਓ ਕਿ ਸਾਰੀਆਂ ਜਾਣੀਆਂ ਦਵਾਈ ਐਲਰਜੀਆਂ ਅੱਪਡੇਟ ਹਨ ਤਾਂ ਜੋ ਨੁਸਖੇ ਦੀਆਂ ਗਲਤੀਆਂ ਤੋਂ ਬਚਿਆ ਜਾ ਸਕੇ।",  // pa
           "Stellen Sie sicher, dass alle bekannten Arzneimittelallergien aktualisiert sind, um Verschreibungsfehler zu vermeiden.",  // de
           "Pastikan semua alergi obat yang diketahui diperbarui untuk mencegah kesalahan resep.",  // jv
           "모든 알려진 약물 알레르기가 업데이트되어 처방 오류를 방지하도록 하십시오.",  // ko
           "Assurez-vous que toutes les allergies médicamenteuses connues sont à jour pour éviter les erreurs de prescription.",  // fr
           "ప్రిస్క్రిప్షన్ పొరపాట్లను నివారించడానికి అన్ని తెలిసిన ఔషధ అలర్జీలు నవీకరించబడ్డాయని నిర్ధారించుకోండి.",  // te
           "सर्व ज्ञात औषध अ‍ॅलर्जी अद्ययावत असल्याची खात्री करा जेणेकरून प्रिस्क्रिप्शन चुका टाळता येतील.",  // mr
           "Reçete hatalarını önlemek için bilinen tüm ilaç alerjilerinin güncel olduğundan emin olun.",  // tr
           "மருந்து சீட்டு பிழைகளைத் தவிர்க்க அனைத்து அறியப்பட்ட மருந்து அலர்ஜிகள் புதுப்பிக்கப்பட்டுள்ளன என்பதை உறுதிசெய்யவும்.",  // ta
           "Đảm bảo tất cả các dị ứng thuốc đã biết được cập nhật để tránh lỗi kê đơn.",  // vi
           "یقینی بنائیں کہ تمام معلوم دوائی الرجیز اپ ڈیٹ ہیں تاکہ نسخے کی غلطیوں سے بچا جا سکے۔",  // ur
           "Assicurati che tutte le allergie ai farmaci siano aggiornate per evitare errori di prescrizione.",  // it
           "ตรวจสอบให้แน่ใจว่าได้อัปเดตอาการแพ้ยาที่ทราบทั้งหมดเพื่อป้องกันข้อผิดพลาดในการสั่งยา",  // th
           "ખાતરી કરો કે તમામ જાણીતી દવાઓની એલર્જી અપડેટ છે જેથી પ્રિસ્ક્રિપ્શન ભૂલો અટકાવી શકાય.",  // gu
           "Upewnij się, że wszystkie znane alergie na leki są aktualne, aby uniknąć błędów w receptach.",  // pl
           "Переконайтеся, що всі відомі алергії на ліки оновлені, щоб уникнути помилок у рецептах.",  // uk
           "اطمینان حاصل کنید که تمام آلرژی‌های دارویی شناخته‌شده به‌روز هستند تا از خطاهای نسخه‌نویسی جلوگیری شود.",  // fa
           "Pastikan semua alahan ubat yang diketahui dikemas kini untuk mengelakkan kesilapan preskripsi.",  // ms
           "Asigurați-vă că toate alergiile cunoscute la medicamente sunt actualizate pentru a preveni erorile de prescriere.",  // ro
           "Zorg ervoor dat alle bekende medicijnallergieën zijn bijgewerkt om voorschrijffouten te voorkomen."  // nl
        );

        public static LanguageText discardChanges = new LanguageText(
           "Discard Changes",  // en
           "Απόρριψη αλλαγών",  // el
           "Descartar cambios",  // es
           "放弃更改",  // zh
           "परिवर्तनों को त्यागें",  // hi
           "تجاهل التغييرات",  // ar
           "Descartar alterações",  // pt
           "পরিবর্তন বাতিল করুন",  // bn
           "Отменить изменения",  // ru
           "変更を破棄",  // jp
           "ਤਬਦੀਲੀਆਂ ਰੱਦ ਕਰੋ",  // pa
           "Änderungen verwerfen",  // de
           "Buang perubahan",  // jv
           "변경 사항 삭제",  // ko
           "Ignorer les modifications",  // fr
           "మార్పులను విస్మరించు",  // te
           "बदल रद्द करा",  // mr
           "Değişiklikleri at",  // tr
           "மாற்றங்களை நிராகரி",  // ta
           "Hủy thay đổi",  // vi
           "تبدیلیاں مسترد کریں",  // ur
           "Annulla modifiche",  // it
           "ยกเลิกการเปลี่ยนแปลง",  // th
           "ફેરફારો રદ કરો",  // gu
           "Odrzuć zmiany",  // pl
           "Скасувати зміни",  // uk
           "لغو تغییرات",  // fa
           "Buang perubahan",  // ms
           "Renunță la modificări",  // ro
           "Wijzigingen negeren"  // nl
        );




        public static LanguageText registration = new LanguageText(
   "REGISTRATION",  // en
   "ΕΓΓΡΑΦΗ",  // el
   "REGISTRO",  // es
   "注册",  // zh
   "पंजीकरण",  // hi
   "التسجيل",  // ar
   "REGISTRO",  // pt
   "নিবন্ধন",  // bn
   "РЕГИСТРАЦИЯ",  // ru
   "登録",  // jp
   "ਰਜਿਸਟ੍ਰੇਸ਼ਨ",  // pa
   "REGISTRIERUNG",  // de
   "Registrasi",  // jv
   "등록",  // ko
   "INSCRIPTION",  // fr
   "నమోదు",  // te
   "नोंदणी",  // mr
   "KAYIT",  // tr
   "பதிவு",  // ta
   "ĐĂNG KÝ",  // vi
   "رجسٹریشن",  // ur
   "REGISTRAZIONE",  // it
   "การลงทะเบียน",  // th
   "નોંધણી",  // gu
   "REJESTRACJA",  // pl
   "РЕЄСТРАЦІЯ",  // uk
   "ثبت‌نام",  // fa
   "Pendaftaran",  // ms
   "ÎNREGISTRARE",  // ro
   "REGISTRATIE"  // nl
);

        public static LanguageText addNewPatient = new LanguageText(
           "Add New Patient",  // en
           "Προσθήκη Νέου Ασθενή",  // el
           "Agregar nuevo paciente",  // es
           "添加新患者",  // zh
           "नया रोगी जोड़ें",  // hi
           "إضافة مريض جديد",  // ar
           "Adicionar novo paciente",  // pt
           "নতুন রোগী যোগ করুন",  // bn
           "Добавить нового пациента",  // ru
           "新しい患者を追加",  // jp
           "ਨਵਾਂ ਮਰੀਜ਼ ਸ਼ਾਮਲ ਕਰੋ",  // pa
           "Neuen Patienten hinzufügen",  // de
           "Tambah pasien baru",  // jv
           "새 환자 추가",  // ko
           "Ajouter un nouveau patient",  // fr
           "కొత్త రోగిని చేర్చండి",  // te
           "नवीन रुग्ण जोडा",  // mr
           "Yeni hasta ekle",  // tr
           "புதிய நோயாளியை சேர்க்கவும்",  // ta
           "Thêm bệnh nhân mới",  // vi
           "نیا مریض شامل کریں",  // ur
           "Aggiungi nuovo paziente",  // it
           "เพิ่มผู้ป่วยใหม่",  // th
           "નવો દર્દી ઉમેરો",  // gu
           "Dodaj nowego pacjenta",  // pl
           "Додати нового пацієнта",  // uk
           "افزودن بیمار جدید",  // fa
           "Tambah pesakit baharu",  // ms
           "Adaugă pacient nou",  // ro
           "Nieuwe patiënt toevoegen"  // nl
        );

        public static LanguageText fullName = new LanguageText(
           "Full Name",  // en
           "Ονοματεπώνυμο",  // el
           "Nombre completo",  // es
           "全名",  // zh
           "पूरा नाम",  // hi
           "الاسم الكامل",  // ar
           "Nome completo",  // pt
           "পূর্ণ নাম",  // bn
           "Полное имя",  // ru
           "氏名",  // jp
           "ਪੂਰਾ ਨਾਮ",  // pa
           "Vollständiger Name",  // de
           "Jeneng lengkap",  // jv
           "전체 이름",  // ko
           "Nom complet",  // fr
           "పూర్తి పేరు",  // te
           "पूर्ण नाव",  // mr
           "Ad Soyad",  // tr
           "முழு பெயர்",  // ta
           "Họ và tên",  // vi
           "پورا نام",  // ur
           "Nome completo",  // it
           "ชื่อเต็ม",  // th
           "પૂર્ણ નામ",  // gu
           "Imię i nazwisko",  // pl
           "Повне ім'я",  // uk
           "نام کامل",  // fa
           "Nama penuh",  // ms
           "Nume complet",  // ro
           "Volledige naam"  // nl
        );

        public static LanguageText gender = new LanguageText(
           "Gender",  // en
           "Φύλο",  // el
           "Género",  // es
           "性别",  // zh
           "लिंग",  // hi
           "الجنس",  // ar
           "Gênero",  // pt
           "লিঙ্গ",  // bn
           "Пол",  // ru
           "性別",  // jp
           "ਲਿੰਗ",  // pa
           "Geschlecht",  // de
           "Jenis kelamin",  // jv
           "성별",  // ko
           "Genre",  // fr
           "లింగం",  // te
           "लिंग",  // mr
           "Cinsiyet",  // tr
           "பாலினம்",  // ta
           "Giới tính",  // vi
           "جنس",  // ur
           "Genere",  // it
           "เพศ",  // th
           "લિંગ",  // gu
           "Płeć",  // pl
           "Стать",  // uk
           "جنسیت",  // fa
           "Jantina",  // ms
           "Gen",  // ro
           "Geslacht"  // nl
        );

        public static LanguageText ssn = new LanguageText(
           "Social Security Number",  // en
           "Αριθμός Κοινωνικής Ασφάλισης",  // el
           "Número de seguro social",  // es
           "社会保障号码",  // zh
           "सामाजिक सुरक्षा संख्या",  // hi
           "رقم الضمان الاجتماعي",  // ar
           "Número de segurança social",  // pt
           "সামাজিক নিরাপত্তা নম্বর",  // bn
           "Номер социального страхования",  // ru
           "社会保障番号",  // jp
           "ਸੋਸ਼ਲ ਸਿਕਿਊਰਿਟੀ ਨੰਬਰ",  // pa
           "Sozialversicherungsnummer",  // de
           "Nomor jaminan sosial",  // jv
           "사회 보장 번호",  // ko
           "Numéro de sécurité sociale",  // fr
           "సోషల్ సెక్యూరిటీ నంబర్",  // te
           "सामाजिक सुरक्षा क्रमांक",  // mr
           "Sosyal güvenlik numarası",  // tr
           "சமூக பாதுகாப்பு எண்",  // ta
           "Số an sinh xã hội",  // vi
           "سوشل سیکیورٹی نمبر",  // ur
           "Numero di previdenza sociale",  // it
           "หมายเลขประกันสังคม",  // th
           "સોશિયલ સિક્યુરિટી નંબર",  // gu
           "Numer ubezpieczenia społecznego",  // pl
           "Номер соціального страхування",  // uk
           "شماره تأمین اجتماعی",  // fa
           "Nombor keselamatan sosial",  // ms
           "Număr de asigurare socială",  // ro
           "Burgerservicenummer"  // nl
        );

      

        public static LanguageText phoneNumber = new LanguageText(
           "Phone Number",  // en
           "Αριθμός Τηλεφώνου",  // el
           "Número de teléfono",  // es
           "电话号码",  // zh
           "फोन नंबर",  // hi
           "رقم الهاتف",  // ar
           "Número de telefone",  // pt
           "ফোন নম্বর",  // bn
           "Номер телефона",  // ru
           "電話番号",  // jp
           "ਫੋਨ ਨੰਬਰ",  // pa
           "Telefonnummer",  // de
           "Nomor telepon",  // jv
           "전화번호",  // ko
           "Numéro de téléphone",  // fr
           "ఫోన్ నంబర్",  // te
           "फोन नंबर",  // mr
           "Telefon numarası",  // tr
           "தொலைபேசி எண்",  // ta
           "Số điện thoại",  // vi
           "فون نمبر",  // ur
           "Numero di telefono",  // it
           "หมายเลขโทรศัพท์",  // th
           "ફોન નંબર",  // gu
           "Numer telefonu",  // pl
           "Номер телефону",  // uk
           "شماره تلفن",  // fa
           "Nombor telefon",  // ms
           "Număr de telefon",  // ro
           "Telefoonnummer"  // nl
        );

        public static LanguageText patientHistory = new LanguageText(
           "Patient History",  // en
           "Ιστορικό Ασθενούς",  // el
           "Historial del paciente",  // es
           "患者病史",  // zh
           "रोगी का इतिहास",  // hi
           "تاريخ المريض",  // ar
           "Histórico do paciente",  // pt
           "রোগীর ইতিহাস",  // bn
           "История пациента",  // ru
           "患者の病歴",  // jp
           "ਮਰੀਜ਼ ਦਾ ਇਤਿਹਾਸ",  // pa
           "Patientenhistorie",  // de
           "Riwayat pasien",  // jv
           "환자 병력",  // ko
           "Historique du patient",  // fr
           "రోగి చరిత్ర",  // te
           "रुग्ण इतिहास",  // mr
           "Hasta geçmişi",  // tr
           "நோயாளர் வரலாறு",  // ta
           "Tiền sử bệnh nhân",  // vi
           "مریض کی تاریخ",  // ur
           "Storia del paziente",  // it
           "ประวัติผู้ป่วย",  // th
           "દર્દીનો ઇતિહાસ",  // gu
           "Historia pacjenta",  // pl
           "Історія пацієнта",  // uk
           "سابقه بیمار",  // fa
           "Sejarah pesakit",  // ms
           "Istoric pacient",  // ro
           "Patiëntgeschiedenis"  // nl
        );

        public static LanguageText viewMedicalTimeline = new LanguageText(
           "View medical timeline",  // en
           "Προβολή ιατρικού χρονοδιαγράμματος",  // el
           "Ver cronología médica",  // es
           "查看医疗时间线",  // zh
           "चिकित्सीय समयरेखा देखें",  // hi
           "عرض الجدول الزمني الطبي",  // ar
           "Ver linha do tempo médica",  // pt
           "মেডিক্যাল টাইমলাইন দেখুন",  // bn
           "Просмотреть медицинскую хронологию",  // ru
           "医療タイムラインを表示",  // jp
           "ਮੈਡੀਕਲ ਟਾਈਮਲਾਈਨ ਵੇਖੋ",  // pa
           "Medizinische Zeitleiste anzeigen",  // de
           "Lihat garis waktu medis",  // jv
           "의료 타임라인 보기",  // ko
           "Voir la chronologie médicale",  // fr
           "వైద్య టైమ్‌లైన్ చూడండి",  // te
           "वैद्यकीय टाइमलाइन पहा",  // mr
           "Tıbbi zaman çizelgesini görüntüle",  // tr
           "மருத்துவ காலவரிசையை பார்க்கவும்",  // ta
           "Xem dòng thời gian y tế",  // vi
           "میڈیکل ٹائم لائن دیکھیں",  // ur
           "Visualizza cronologia medica",  // it
           "ดูไทม์ไลน์ทางการแพทย์",  // th
           "મેડિકલ ટાઇમલાઇન જુઓ",  // gu
           "Zobacz oś czasu medyczną",  // pl
           "Переглянути медичну хронологію",  // uk
           "مشاهده خط زمانی پزشکی",  // fa
           "Lihat garis masa perubatan",  // ms
           "Vezi cronologia medicală",  // ro
           "Bekijk medische tijdlijn"  // nl
        );

        public static LanguageText diagnoses = new LanguageText(
           "Diagnoses",  // en
           "Διαγνώσεις",  // el
           "Diagnósticos",  // es
           "诊断",  // zh
           "निदान",  // hi
           "التشخيصات",  // ar
           "Diagnósticos",  // pt
           "নির্ণয়সমূহ",  // bn
           "Диагнозы",  // ru
           "診断",  // jp
           "ਨਿਦਾਨ",  // pa
           "Diagnosen",  // de
           "Diagnosis",  // jv
           "진단",  // ko
           "Diagnostics",  // fr
           "నిర్ధారణలు",  // te
           "निदाने",  // mr
           "Teşhisler",  // tr
           "நோயறிதல்கள்",  // ta
           "Chẩn đoán",  // vi
           "تشخیصات",  // ur
           "Diagnosi",  // it
           "การวินิจฉัย",  // th
           "નિદાન",  // gu
           "Diagnozy",  // pl
           "Діагнози",  // uk
           "تشخیص‌ها",  // fa
           "Diagnosis",  // ms
           "Diagnostice",  // ro
           "Diagnoses"  // nl
        );

        public static LanguageText prescriptions = new LanguageText(
           "Prescriptions",  // en
           "Συνταγές",  // el
           "Recetas",  // es
           "处方",  // zh
           "प्रिस्क्रिप्शन",  // hi
           "الوصفات الطبية",  // ar
           "Prescrições",  // pt
           "প্রেসক্রিপশনসমূহ",  // bn
           "Рецепты",  // ru
           "処方箋",  // jp
           "ਨੁਸਖੇ",  // pa
           "Rezepte",  // de
           "Resep",  // jv
           "처방전",  // ko
           "Ordonnances",  // fr
           "ప్రిస్క్రిప్షన్లు",  // te
           "प्रिस्क्रिप्शन",  // mr
           "Reçeteler",  // tr
           "மருந்து சீட்டுகள்",  // ta
           "Đơn thuốc",  // vi
           "نسخے",  // ur
           "Prescrizioni",  // it
           "ใบสั่งยา",  // th
           "પ્રિસ્ક્રિપ્શન",  // gu
           "Recepty",  // pl
           "Рецепти",  // uk
           "نسخه‌ها",  // fa
           "Preskripsi",  // ms
           "Prescripții",  // ro
           "Voorschriften"  // nl
        );

        public static LanguageText editRecord = new LanguageText(
           "EDIT RECORD",  // en
           "ΕΠΕΞΕΡΓΑΣΙΑ ΕΓΓΡΑΦΗΣ",  // el
           "EDITAR REGISTRO",  // es
           "编辑记录",  // zh
           "रिकॉर्ड संपादित करें",  // hi
           "تعديل السجل",  // ar
           "EDITAR REGISTRO",  // pt
           "রেকর্ড সম্পাদনা",  // bn
           "РЕДАКТИРОВАТЬ ЗАПИСЬ",  // ru
           "記録を編集",  // jp
           "ਰਿਕਾਰਡ ਸੋਧੋ",  // pa
           "DATENSATZ BEARBEITEN",  // de
           "Edit rekaman",  // jv
           "기록 수정",  // ko
           "MODIFIER L'ENREGISTREMENT",  // fr
           "రికార్డ్ సవరించు",  // te
           "रेकॉर्ड संपादित करा",  // mr
           "Kaydı düzenle",  // tr
           "பதிவை திருத்து",  // ta
           "Chỉnh sửa hồ sơ",  // vi
           "ریکارڈ میں ترمیم کریں",  // ur
           "MODIFICA RECORD",  // it
           "แก้ไขบันทึก",  // th
           "રેકોર્ડ સંપાદિત કરો",  // gu
           "EDYTUJ REKORD",  // pl
           "РЕДАГУВАТИ ЗАПИС",  // uk
           "ویرایش رکورد",  // fa
           "Edit rekod",  // ms
           "EDITEAZĂ ÎNREGISTRAREA",  // ro
           "RECORD BEWERKEN"  // nl
        );

        public static LanguageText modifyPatient = new LanguageText(
           "Modify Patient",  // en
           "Τροποποίηση Ασθενούς",  // el
           "Modificar paciente",  // es
           "修改患者",  // zh
           "रोगी संशोधित करें",  // hi
           "تعديل المريض",  // ar
           "Modificar paciente",  // pt
           "রোগী সংশোধন করুন",  // bn
           "Изменить пациента",  // ru
           "患者を変更",  // jp
           "ਮਰੀਜ਼ ਸੋਧੋ",  // pa
           "Patient ändern",  // de
           "Ubah pasien",  // jv
           "환자 수정",  // ko
           "Modifier le patient",  // fr
           "రోగిని సవరించు",  // te
           "रुग्ण बदला",  // mr
           "Hastayı değiştir",  // tr
           "நோயாளியை மாற்று",  // ta
           "Chỉnh sửa bệnh nhân",  // vi
           "مریض میں ترمیم کریں",  // ur
           "Modifica paziente",  // it
           "แก้ไขผู้ป่วย",  // th
           "દર્દી ફેરફાર કરો",  // gu
           "Modyfikuj pacjenta",  // pl
           "Змінити пацієнта",  // uk
           "ویرایش بیمار",  // fa
           "Ubah pesakit",  // ms
           "Modifică pacientul",  // ro
           "Patiënt wijzigen"  // nl
        );

        public static LanguageText updateInfo = new LanguageText(
           "Update Info",  // en
           "Ενημέρωση Πληροφοριών",  // el
           "Actualizar información",  // es
           "更新信息",  // zh
           "जानकारी अपडेट करें",  // hi
           "تحديث المعلومات",  // ar
           "Atualizar informações",  // pt
           "তথ্য আপডেট করুন",  // bn
           "Обновить информацию",  // ru
           "情報を更新",  // jp
           "ਜਾਣਕਾਰੀ ਅਪਡੇਟ ਕਰੋ",  // pa
           "Informationen aktualisieren",  // de
           "Perbarui info",  // jv
           "정보 업데이트",  // ko
           "Mettre à jour les informations",  // fr
           "సమాచారం నవీకరించు",  // te
           "माहिती अद्यतनित करा",  // mr
           "Bilgileri güncelle",  // tr
           "தகவலை புதுப்பிக்கவும்",  // ta
           "Cập nhật thông tin",  // vi
           "معلومات اپڈیٹ کریں",  // ur
           "Aggiorna informazioni",  // it
           "อัปเดตข้อมูล",  // th
           "માહિતી અપડેટ કરો",  // gu
           "Aktualizuj informacje",  // pl
           "Оновити інформацію",  // uk
           "به‌روزرسانی اطلاعات",  // fa
           "Kemas kini maklumat",  // ms
           "Actualizează informațiile",  // ro
           "Informatie bijwerken"  // nl
        );

        public static LanguageText numericValidation = new LanguageText(
           "Please check that all numeric fields are filled correctly.",  // en
           "Παρακαλώ ελέγξτε ότι όλα τα αριθμητικά πεδία έχουν συμπληρωθεί σωστά.",  // el
           "Por favor, verifique que todos los campos numéricos estén completos correctamente.",  // es
           "请检查所有数字字段是否正确填写。",  // zh
           "कृपया जांचें कि सभी संख्यात्मक फ़ील्ड सही भरे गए हैं।",  // hi
           "يرجى التحقق من أن جميع الحقول الرقمية قد تم ملؤها بشكل صحيح.",  // ar
           "Por favor, verifique se todos os campos numéricos foram preenchidos corretamente.",  // pt
           "অনুগ্রহ করে যাচাই করুন যে সব সংখ্যাসূচক ঘর সঠিকভাবে পূরণ করা হয়েছে।",  // bn
           "Пожалуйста, проверьте, что все числовые поля заполнены правильно.",  // ru
           "すべての数値フィールドが正しく入力されているか確認してください。",  // jp
           "ਕਿਰਪਾ ਕਰਕੇ ਜਾਂਚ ਕਰੋ ਕਿ ਸਾਰੇ ਅੰਕ ਵਾਲੇ ਖੇਤਰ ਠੀਕ ਤਰ੍ਹਾਂ ਭਰੇ ਗਏ ਹਨ।",  // pa
           "Bitte überprüfen Sie, ob alle numerischen Felder korrekt ausgefüllt sind.",  // de
           "Harap periksa bahwa semua kolom numerik telah diisi dengan benar.",  // jv
           "모든 숫자 필드가 올바르게 입력되었는지 확인하십시오.",  // ko
           "Veuillez vérifier que tous les champs numériques sont correctement remplis.",  // fr
           "అన్ని సంఖ్యా ఫీల్డ్‌లు సరిగా నింపబడ్డాయో లేదో తనిఖీ చేయండి.",  // te
           "कृपया सर्व संख्यात्मक फील्ड योग्यरित्या भरले आहेत का ते तपासा.",  // mr
           "Lütfen tüm sayısal alanların doğru doldurulduğunu kontrol edin.",  // tr
           "அனைத்து எண் புலங்களும் சரியாக நிரப்பப்பட்டுள்ளனவா என்பதை சரிபார்க்கவும்.",  // ta
           "Vui lòng kiểm tra tất cả các trường số đã được điền đúng.",  // vi
           "براہ کرم چیک کریں کہ تمام عددی خانے درست بھرے گئے ہیں۔",  // ur
           "Controlla che tutti i campi numerici siano compilati correttamente.",  // it
           "โปรดตรวจสอบว่าช่องตัวเลขทั้งหมดถูกกรอกอย่างถูกต้อง",  // th
           "કૃપા કરીને તપાસો કે તમામ સંખ્યાત્મક ક્ષેત્રો યોગ્ય રીતે ભરેલા છે.",  // gu
           "Proszę sprawdzić, czy wszystkie pola numeryczne są poprawnie wypełnione.",  // pl
           "Будь ласка, перевірте, що всі числові поля заповнені правильно.",  // uk
           "لطفاً بررسی کنید که همه فیلدهای عددی به‌درستی پر شده‌اند.",  // fa
           "Sila semak bahawa semua medan berangka diisi dengan betul.",  // ms
           "Vă rugăm să verificați că toate câmpurile numerice sunt completate corect.",  // ro
           "Controleer of alle numerieke velden correct zijn ingevuld."  // nl
        );

        public static LanguageText undefined = new LanguageText(
       "undefined",  // en
       "απροσδιόριστο",  // el
       "indefinido",  // es
       "未定义",  // zh
       "अपरिभाषित",  // hi
       "غير محدد",  // ar
       "indefinido",  // pt
       "অনির্ধারিত",  // bn
       "неопределено",  // ru
       "未定義",  // jp
       "ਅਣਨਿਰਧਾਰਤ",  // pa
       "undefiniert",  // de
       "ora ditemtokake",  // jv
       "정의되지 않음",  // ko
       "indéfini",  // fr
       "నిర్వచించబడని",  // te
       "अपरिभाषित",  // mr
       "tanımsız",  // tr
       "வரையறுக்கப்படாத",  // ta
       "không xác định",  // vi
       "غیر متعین",  // ur
       "non definito",  // it
       "ไม่กำหนด",  // th
       "અનિર્ધારિત",  // gu
       "niezdefiniowane",  // pl
       "невизначено",  // uk
       "تعریف‌نشده",  // fa
       "tidak ditentukan",  // ms
       "nedefinit",  // ro
       "ongedefinieerd"  // nl
    );

        public static LanguageText male = new LanguageText(
           "male",  // en
           "άνδρας",  // el
           "masculino",  // es
           "男性",  // zh
           "पुरुष",  // hi
           "ذكر",  // ar
           "masculino",  // pt
           "পুরুষ",  // bn
           "мужской",  // ru
           "男性",  // jp
           "ਪੁਰਸ਼",  // pa
           "männlich",  // de
           "lanang",  // jv
           "남성",  // ko
           "masculin",  // fr
           "పురుషుడు",  // te
           "पुरुष",  // mr
           "erkek",  // tr
           "ஆண்",  // ta
           "nam",  // vi
           "مرد",  // ur
           "maschile",  // it
           "ชาย",  // th
           "પુરુષ",  // gu
           "mężczyzna",  // pl
           "чоловічий",  // uk
           "مرد",  // fa
           "lelaki",  // ms
           "masculin",  // ro
           "man"  // nl
        );

        public static LanguageText female = new LanguageText(
           "female",  // en
           "γυναίκα",  // el
           "femenino",  // es
           "女性",  // zh
           "महिला",  // hi
           "أنثى",  // ar
           "feminino",  // pt
           "মহিলা",  // bn
           "женский",  // ru
           "女性",  // jp
           "ਇਸਤਰੀ",  // pa
           "weiblich",  // de
           "wadon",  // jv
           "여성",  // ko
           "féminin",  // fr
           "స్త్రీ",  // te
           "महिला",  // mr
           "kadın",  // tr
           "பெண்",  // ta
           "nữ",  // vi
           "عورت",  // ur
           "femminile",  // it
           "หญิง",  // th
           "સ્ત્રી",  // gu
           "kobieta",  // pl
           "жіночий",  // uk
           "زن",  // fa
           "perempuan",  // ms
           "feminin",  // ro
           "vrouw"  // nl
        );

        public static LanguageText datePassedNotice = new LanguageText(
   "Notice! Date has already passed",  // en
   "Ειδοποίηση! Η ημερομηνία έχει ήδη περάσει",  // el
   "¡Aviso! La fecha ya ha pasado",  // es
   "注意！日期已过",  // zh
   "सूचना! तिथि पहले ही बीत चुकी है",  // hi
   "تنبيه! التاريخ قد مضى بالفعل",  // ar
   "Aviso! A data já passou",  // pt
   "নোটিশ! তারিখ ইতিমধ্যেই পেরিয়ে গেছে",  // bn
   "Внимание! Дата уже прошла",  // ru
   "注意！日付はすでに過ぎています",  // jp
   "ਸੂਚਨਾ! ਤਾਰੀਖ ਪਹਿਲਾਂ ਹੀ ਲੰਘ ਚੁੱਕੀ ਹੈ",  // pa
   "Hinweis! Das Datum ist bereits vergangen",  // de
   "Peringatan! Tanggal sudah lewat",  // jv
   "알림! 날짜가 이미 지났습니다",  // ko
   "Attention ! La date est déjà passée",  // fr
   "గమనిక! తేదీ ఇప్పటికే గడిచింది",  // te
   "सूचना! तारीख आधीच निघून गेली आहे",  // mr
   "Uyarı! Tarih zaten geçti",  // tr
   "கவனம்! தேதி ஏற்கனவே கடந்துவிட்டது",  // ta
   "Thông báo! Ngày đã qua",  // vi
   "اطلاع! تاریخ گزر چکی ہے",  // ur
   "Avviso! La data è già passata",  // it
   "แจ้งเตือน! วันที่ผ่านไปแล้ว",  // th
   "સૂચના! તારીખ પહેલેથી પસાર થઈ ગઈ છે",  // gu
   "Uwaga! Data już minęła",  // pl
   "Увага! Дата вже минула",  // uk
   "توجه! تاریخ قبلاً گذشته است",  // fa
   "Notis! Tarikh telah berlalu",  // ms
   "Atenție! Data a trecut deja",  // ro
   "Let op! De datum is al verstreken"  // nl
);

        public static LanguageText noAppointments = new LanguageText(
           "No appointments found for this date.",  // en
           "Δεν βρέθηκαν ραντεβού για αυτή την ημερομηνία.",  // el
           "No se encontraron citas para esta fecha.",  // es
           "未找到该日期的预约。",  // zh
           "इस तिथि के लिए कोई अपॉइंटमेंट नहीं मिला।",  // hi
           "لم يتم العثور على مواعيد لهذا التاريخ.",  // ar
           "Nenhuma consulta encontrada para esta data.",  // pt
           "এই তারিখের জন্য কোনো অ্যাপয়েন্টমেন্ট পাওয়া যায়নি।",  // bn
           "На эту дату записи не найдены.",  // ru
           "この日に予約は見つかりませんでした。",  // jp
           "ਇਸ ਤਾਰੀਖ ਲਈ ਕੋਈ ਮੀਟਿੰਗ ਨਹੀਂ ਮਿਲੀ।",  // pa
           "Keine Termine für dieses Datum gefunden.",  // de
           "Ora ana janji kanggo tanggal iki.",  // jv
           "이 날짜에 대한 예약이 없습니다.",  // ko
           "Aucun rendez-vous trouvé pour cette date.",  // fr
           "ఈ తేదీకి ఎలాంటి అపాయింట్‌మెంట్‌లు లేవు.",  // te
           "या तारखेसाठी कोणतीही भेट सापडली नाही.",  // mr
           "Bu tarih için randevu bulunamadı.",  // tr
           "இந்த தேதிக்கு எந்த சந்திப்பும் கிடைக்கவில்லை.",  // ta
           "Không tìm thấy cuộc hẹn cho ngày này.",  // vi
           "اس تاریخ کے لیے کوئی ملاقات نہیں ملی۔",  // ur
           "Nessun appuntamento trovato per questa data.",  // it
           "ไม่พบการนัดหมายสำหรับวันที่นี้",  // th
           "આ તારીખ માટે કોઈ અપોઇન્ટમેન્ટ મળ્યું નથી.",  // gu
           "Nie znaleziono wizyt na tę datę.",  // pl
           "На цю дату записів не знайдено.",  // uk
           "هیچ نوبتی برای این تاریخ یافت نشد.",  // fa
           "Tiada janji temu ditemui untuk tarikh ini.",  // ms
           "Nu au fost găsite programări pentru această dată.",  // ro
           "Geen afspraken gevonden voor deze datum."  // nl
        );

        public static LanguageText fillPatientNameFirst = new LanguageText(
           "Fill in the patients name first",  // en
           "Συμπληρώστε πρώτα το όνομα του ασθενούς",  // el
           "Primero complete el nombre del paciente",  // es
           "请先填写患者姓名",  // zh
           "कृपया पहले रोगी का नाम भरें",  // hi
           "يرجى إدخال اسم المريض أولاً",  // ar
           "Preencha primeiro o nome do paciente",  // pt
           "প্রথমে রোগীর নাম পূরণ করুন",  // bn
           "Сначала введите имя пациента",  // ru
           "まず患者の名前を入力してください",  // jp
           "ਪਹਿਲਾਂ ਮਰੀਜ਼ ਦਾ ਨਾਮ ਭਰੋ",  // pa
           "Geben Sie zuerst den Namen des Patienten ein",  // de
           "Isi jeneng pasien dhisik",  // jv
           "먼저 환자 이름을 입력하세요",  // ko
           "Veuillez d'abord remplir le nom du patient",  // fr
           "ముందుగా రోగి పేరును నమోదు చేయండి",  // te
           "प्रथम रुग्णाचे नाव भरा",  // mr
           "Önce hasta adını girin",  // tr
           "முதலில் நோயாளியின் பெயரை நிரப்பவும்",  // ta
           "Vui lòng nhập tên bệnh nhân trước",  // vi
           "پہلے مریض کا نام درج کریں",  // ur
           "Inserisci prima il nome del paziente",  // it
           "กรุณากรอกชื่อผู้ป่วยก่อน",  // th
           "પહેલા દર્દીનું નામ ભરો",  // gu
           "Najpierw wpisz nazwisko pacjenta",  // pl
           "Спочатку введіть ім'я пацієнта",  // uk
           "ابتدا نام بیمار را وارد کنید",  // fa
           "Isi nama pesakit dahulu",  // ms
           "Introduceți mai întâi numele pacientului",  // ro
           "Vul eerst de naam van de patiënt in"  // nl
        );

        public static LanguageText patientNotRegistered = new LanguageText(
           "Note The patient is not registered",  // en
           "Σημείωση: Ο ασθενής δεν είναι καταχωρημένος",  // el
           "Nota: El paciente no está registrado",  // es
           "注意：患者未注册",  // zh
           "नोट: रोगी पंजीकृत नहीं है",  // hi
           "ملاحظة: المريض غير مسجل",  // ar
           "Nota: O paciente não está registrado",  // pt
           "নোট: রোগী নিবন্ধিত নয়",  // bn
           "Примечание: пациент не зарегистрирован",  // ru
           "注意：患者は登録されていません",  // jp
           "ਨੋਟ: ਮਰੀਜ਼ ਰਜਿਸਟਰ ਨਹੀਂ ਹੈ",  // pa
           "Hinweis: Der Patient ist nicht registriert",  // de
           "Cathetan: pasien durung kadhaptar",  // jv
           "참고: 환자가 등록되지 않았습니다",  // ko
           "Remarque : le patient n'est pas enregistré",  // fr
           "గమనిక: రోగి నమోదు కాలేదు",  // te
           "नोंद: रुग्ण नोंदणीकृत नाही",  // mr
           "Not: Hasta kayıtlı değil",  // tr
           "குறிப்பு: நோயாளர் பதிவு செய்யப்படவில்லை",  // ta
           "Lưu ý: Bệnh nhân chưa được đăng ký",  // vi
           "نوٹ: مریض رجسٹرڈ نہیں ہے",  // ur
           "Nota: il paziente non è registrato",  // it
           "หมายเหตุ: ผู้ป่วยยังไม่ได้ลงทะเบียน",  // th
           "નોંધ: દર્દી નોંધાયેલ નથી",  // gu
           "Uwaga: pacjent nie jest zarejestrowany",  // pl
           "Примітка: пацієнт не зареєстрований",  // uk
           "نکته: بیمار ثبت نشده است",  // fa
           "Nota: Pesakit tidak berdaftar",  // ms
           "Notă: pacientul nu este înregistrat",  // ro
           "Opmerking: patiënt is niet geregistreerd"  // nl
        );

        public static LanguageText numericBoxesError = new LanguageText(
           "Please fill the number boxes correctly.",  // en
           "Παρακαλώ συμπληρώστε σωστά τα αριθμητικά πεδία.",  // el
           "Por favor, complete correctamente los campos numéricos.",  // es
           "请正确填写数字字段。",  // zh
           "कृपया संख्यात्मक फ़ील्ड सही भरें।",  // hi
           "يرجى تعبئة الحقول الرقمية بشكل صحيح.",  // ar
           "Por favor, preencha corretamente os campos numéricos.",  // pt
           "দয়া করে সংখ্যাসূচক ঘরগুলো সঠিকভাবে পূরণ করুন।",  // bn
           "Пожалуйста, правильно заполните числовые поля.",  // ru
           "数値フィールドを正しく入力してください。",  // jp
           "ਕਿਰਪਾ ਕਰਕੇ ਅੰਕ ਵਾਲੇ ਖੇਤਰ ਠੀਕ ਤਰ੍ਹਾਂ ਭਰੋ।",  // pa
           "Bitte füllen Sie die numerischen Felder korrekt aus.",  // de
           "Isi kolom angka kanthi bener.",  // jv
           "숫자 필드를 올바르게 입력하세요.",  // ko
           "Veuillez remplir correctement les champs numériques.",  // fr
           "సంఖ్యా ఫీల్డ్‌లను సరిగ్గా నింపండి.",  // te
           "कृपया संख्यात्मक फील्ड योग्य भरा.",  // mr
           "Lütfen sayısal alanları doğru doldurun.",  // tr
           "எண் புலங்களை சரியாக நிரப்பவும்.",  // ta
           "Vui lòng điền đúng các trường số.",  // vi
           "براہ کرم عددی خانے درست بھریں۔",  // ur
           "Compila correttamente i campi numerici.",  // it
           "กรุณากรอกช่องตัวเลขให้ถูกต้อง",  // th
           "કૃપા કરીને સંખ્યાત્મક ક્ષેત્રો સાચા ભરો.",  // gu
           "Proszę poprawnie wypełnić pola numeryczne.",  // pl
           "Будь ласка, правильно заповніть числові поля.",  // uk
           "لطفاً فیلدهای عددی را به‌درستی پر کنید.",  // fa
           "Sila isi medan nombor dengan betul.",  // ms
           "Vă rugăm să completați corect câmpurile numerice.",  // ro
           "Vul de numerieke velden correct in."  // nl
        );

        public static LanguageText selectDuration = new LanguageText(
           "Please select a duration.",  // en
           "Παρακαλώ επιλέξτε διάρκεια.",  // el
           "Por favor, seleccione una duración.",  // es
           "请选择一个时长。",  // zh
           "कृपया अवधि चुनें।",  // hi
           "يرجى اختيار مدة.",  // ar
           "Por favor, selecione uma duração.",  // pt
           "অনুগ্রহ করে একটি সময়কাল নির্বাচন করুন।",  // bn
           "Пожалуйста, выберите продолжительность.",  // ru
           "期間を選択してください。",  // jp
           "ਕਿਰਪਾ ਕਰਕੇ ਮਿਆਦ ਚੁਣੋ।",  // pa
           "Bitte wählen Sie eine Dauer.",  // de
           "Pilih durasi.",  // jv
           "기간을 선택하세요.",  // ko
           "Veuillez sélectionner une durée.",  // fr
           "దయచేసి వ్యవధిని ఎంచుకోండి.",  // te
           "कृपया कालावधी निवडा.",  // mr
           "Lütfen bir süre seçin.",  // tr
           "ஒரு காலத்தைத் தேர்ந்தெடுக்கவும்.",  // ta
           "Vui lòng chọn thời lượng.",  // vi
           "براہ کرم مدت منتخب کریں۔",  // ur
           "Seleziona una durata.",  // it
           "กรุณาเลือกระยะเวลา",  // th
           "કૃપા કરીને સમયગાળો પસંદ કરો.",  // gu
           "Proszę wybrać czas trwania.",  // pl
           "Будь ласка, виберіть тривалість.",  // uk
           "لطفاً یک مدت زمان انتخاب کنید.",  // fa
           "Sila pilih tempoh.",  // ms
           "Vă rugăm să selectați o durată.",  // ro
           "Selecteer een duur."  // nl
        );

        public static LanguageText invalidDate = new LanguageText(
           "The date provided is invalid (e.g., check the days in the month).",  // en
           "Η παρεχόμενη ημερομηνία δεν είναι έγκυρη (π.χ. ελέγξτε τις ημέρες του μήνα).",  // el
           "La fecha proporcionada no es válida (por ejemplo, verifique los días del mes).",  // es
           "提供的日期无效（例如，请检查月份中的天数）。",  // zh
           "प्रदान की गई तिथि अमान्य है (जैसे, महीने के दिनों की जांच करें)।",  // hi
           "التاريخ المدخل غير صالح (تحقق من أيام الشهر).",  // ar
           "A data fornecida é inválida (verifique os dias do mês).",  // pt
           "প্রদত্ত তারিখটি অবৈধ (মাসের দিনগুলো পরীক্ষা করুন)।",  // bn
           "Указанная дата недействительна (проверьте дни в месяце).",  // ru
           "入力された日付は無効です（例：月の日数を確認してください）。",  // jp
           "ਦਿੱਤੀ ਗਈ ਤਾਰੀਖ ਅਵੈਧ ਹੈ (ਮਹੀਨੇ ਦੇ ਦਿਨ ਚੈੱਕ ਕਰੋ)।",  // pa
           "Das angegebene Datum ist ungültig (z. B. Tage im Monat prüfen).",  // de
           "Tanggal ora valid (priksa dina ing wulan).",  // jv
           "입력한 날짜가 유효하지 않습니다(월의 일수를 확인하세요).",  // ko
           "La date fournie est invalide (vérifiez les jours du mois).",  // fr
           "ఇచ్చిన తేదీ చెల్లదు (నెలలో రోజుల సంఖ్యను తనిఖీ చేయండి).",  // te
           "दिलेली तारीख अमान्य आहे (महिन्यातील दिवस तपासा).",  // mr
           "Girilen tarih geçersiz (ay günlerini kontrol edin).",  // tr
           "கொடுக்கப்பட்ட தேதி தவறானது (மாதத்தின் நாட்களை சரிபார்க்கவும்).",  // ta
           "Ngày cung cấp không hợp lệ (kiểm tra số ngày trong tháng).",  // vi
           "دی گئی تاریخ غلط ہے (مہینے کے دن چیک کریں).",  // ur
           "La data fornita non è valida (controlla i giorni del mese).",  // it
           "วันที่ไม่ถูกต้อง (ตรวจสอบจำนวนวันในเดือน)",  // th
           "આપેલી તારીખ અમાન્ય છે (મહિનાના દિવસો તપાસો).",  // gu
           "Podana data jest nieprawidłowa (sprawdź dni w miesiącu).",  // pl
           "Вказана дата недійсна (перевірте дні в місяці).",  // uk
           "تاریخ وارد شده نامعتبر است (روزهای ماه را بررسی کنید).",  // fa
           "Tarikh yang diberikan tidak sah (semak hari dalam bulan).",  // ms
           "Data furnizată este invalidă (verificați zilele din lună).",  // ro
           "De opgegeven datum is ongeldig (controleer de dagen in de maand)."  // nl
        );

        public static LanguageText scheduleConflict = new LanguageText(
           "Schedule Conflict:",  // en
           "Σύγκρουση Προγράμματος:",  // el
           "Conflicto de horario:",  // es
           "时间冲突：",  // zh
           "समय-सारिणी टकराव:",  // hi
           "تعارض في الجدول:",  // ar
           "Conflito de agenda:",  // pt
           "সময়সূচির সংঘর্ষ:",  // bn
           "Конфликт расписания:",  // ru
           "スケジュールの競合:",  // jp
           "ਸ਼ਡਿਊਲ ਟਕਰਾਅ:",  // pa
           "Zeitplan-Konflikt:",  // de
           "Konflik jadwal:",  // jv
           "일정 충돌:",  // ko
           "Conflit d'horaire:",  // fr
           "షెడ్యూల్ ఘర్షణ:",  // te
           "वेळापत्रक संघर्ष:",  // mr
           "Zamanlama çakışması:",  // tr
           "அட்டவணை முரண்பாடு:",  // ta
           "Xung đột lịch:",  // vi
           "شیڈول تنازع:",  // ur
           "Conflitto di pianificazione:",  // it
           "ตารางเวลาขัดแย้ง:",  // th
           "સમયપત્રક સંઘર્ષ:",  // gu
           "Konflikt harmonogramu:",  // pl
           "Конфлікт розкладу:",  // uk
           "تداخل برنامه:",  // fa
           "Konflik jadual:",  // ms
           "Conflict de program:",  // ro
           "Planningsconflict:"  // nl
        );

        public static LanguageText slotAvailable = new LanguageText(
           "Time slot is available.",  // en
           "Η χρονική περίοδος είναι διαθέσιμη.",  // el
           "El horario está disponible.",  // es
           "时间段可用。",  // zh
           "समय स्लॉट उपलब्ध है।",  // hi
           "الفترة الزمنية متاحة.",  // ar
           "O horário está disponível.",  // pt
           "সময় স্লট উপলব্ধ।",  // bn
           "Временной слот доступен.",  // ru
           "時間枠は利用可能です。",  // jp
           "ਸਮਾਂ ਸਲਾਟ ਉਪਲਬਧ ਹੈ।",  // pa
           "Zeitfenster ist verfügbar.",  // de
           "Slot wektu kasedhiya.",  // jv
           "시간 슬롯이 사용 가능합니다.",  // ko
           "Le créneau est disponible.",  // fr
           "సమయ స్లాట్ అందుబాటులో ఉంది.",  // te
           "वेळ स्लॉट उपलब्ध आहे.",  // mr
           "Zaman dilimi uygun.",  // tr
           "நேர இடைவெளி கிடைக்கிறது.",  // ta
           "Khung giờ có sẵn.",  // vi
           "ٹائم سلاٹ دستیاب ہے۔",  // ur
           "La fascia oraria è disponibile.",  // it
           "ช่วงเวลาว่าง",  // th
           "સમય સ્લોટ ઉપલબ્ધ છે.",  // gu
           "Termin jest dostępny.",  // pl
           "Часовий слот доступний.",  // uk
           "بازه زمانی در دسترس است.",  // fa
           "Slot masa tersedia.",  // ms
           "Intervalul orar este disponibil.",  // ro
           "Tijdslot is beschikbaar."  // nl
        );
        public static LanguageText day = new LanguageText(
   "day",  // en
   "ημέρα",  // el
   "día",  // es
   "天",  // zh
   "दिन",  // hi
   "يوم",  // ar
   "dia",  // pt
   "দিন",  // bn
   "день",  // ru
   "日",  // jp
   "ਦਿਨ",  // pa
   "Tag",  // de
   "dina",  // jv
   "일",  // ko
   "jour",  // fr
   "రోజు",  // te
   "दिवस",  // mr
   "gün",  // tr
   "நாள்",  // ta
   "ngày",  // vi
   "دن",  // ur
   "giorno",  // it
   "วัน",  // th
   "દિવસ",  // gu
   "dzień",  // pl
   "день",  // uk
   "روز",  // fa
   "hari",  // ms
   "zi",  // ro
   "dag"  // nl
);

        public static LanguageText month = new LanguageText(
           "month",  // en
           "μήνας",  // el
           "mes",  // es
           "月",  // zh
           "महीना",  // hi
           "شهر",  // ar
           "mês",  // pt
           "মাস",  // bn
           "месяц",  // ru
           "月",  // jp
           "ਮਹੀਨਾ",  // pa
           "Monat",  // de
           "wulan",  // jv
           "월",  // ko
           "mois",  // fr
           "నెల",  // te
           "महिना",  // mr
           "ay",  // tr
           "மாதம்",  // ta
           "tháng",  // vi
           "مہینہ",  // ur
           "mese",  // it
           "เดือน",  // th
           "મહિનો",  // gu
           "miesiąc",  // pl
           "місяць",  // uk
           "ماه",  // fa
           "bulan",  // ms
           "lună",  // ro
           "maand"  // nl
        );

        public static LanguageText year = new LanguageText(
           "year",  // en
           "έτος",  // el
           "año",  // es
           "年",  // zh
           "वर्ष",  // hi
           "سنة",  // ar
           "ano",  // pt
           "বছর",  // bn
           "год",  // ru
           "年",  // jp
           "ਸਾਲ",  // pa
           "Jahr",  // de
           "taun",  // jv
           "년",  // ko
           "an",  // fr
           "సంవత్సరం",  // te
           "वर्ष",  // mr
           "yıl",  // tr
           "ஆண்டு",  // ta
           "năm",  // vi
           "سال",  // ur
           "anno",  // it
           "ปี",  // th
           "વર્ષ",  // gu
           "rok",  // pl
           "рік",  // uk
           "سال",  // fa
           "tahun",  // ms
           "an",  // ro
           "jaar"  // nl
        );

        public static LanguageText appointmentCaps = new LanguageText(
   "APPOINTMENT",  // en
   "ΡΑΝΤΕΒΟΥ",  // el
   "CITA",  // es
   "预约",  // zh
   "अपॉइंटमेंट",  // hi
   "موعد",  // ar
   "AGENDAMENTO",  // pt
   "অ্যাপয়েন্টমেন্ট",  // bn
   "ЗАПИСЬ",  // ru
   "予約",  // jp
   "ਮੁਲਾਕਾਤ",  // pa
   "TERMIN",  // de
   "Janji",  // jv
   "예약",  // ko
   "RENDEZ-VOUS",  // fr
   "అపాయింట్‌మెంట్",  // te
   "अपॉइंटमेंट",  // mr
   "RANDEVU",  // tr
   "நியமனம்",  // ta
   "CUỘC HẸN",  // vi
   "اپائنٹمنٹ",  // ur
   "APPUNTAMENTO",  // it
   "การนัดหมาย",  // th
   "અપોઇન્ટમેન્ટ",  // gu
   "WIZYTA",  // pl
   "ЗАПИС",  // uk
   "قرار ملاقات",  // fa
   "JANJI TEMU",  // ms
   "PROGRAMARE",  // ro
   "AFSPRAAK"  // nl
);

        public static LanguageText scheduleNewVisit = new LanguageText(
           "Schedule New Visit",  // en
           "Προγραμματισμός Νέας Επίσκεψης",  // el
           "Programar nueva visita",  // es
           "安排新就诊",  // zh
           "नई विज़िट शेड्यूल करें",  // hi
           "جدولة زيارة جديدة",  // ar
           "Agendar nova visita",  // pt
           "নতুন ভিজিট নির্ধারণ করুন",  // bn
           "Запланировать новый визит",  // ru
           "新しい訪問をスケジュール",  // jp
           "ਨਵੀਂ ਮੁਲਾਕਾਤ ਤਹਿ ਕਰੋ",  // pa
           "Neuen Besuch planen",  // de
           "Jadwal kunjungan anyar",  // jv
           "새 방문 일정 잡기",  // ko
           "Planifier une nouvelle visite",  // fr
           "కొత్త సందర్శనను షెడ్యూల్ చేయండి",  // te
           "नवीन भेट नियोजित करा",  // mr
           "Yeni ziyaret planla",  // tr
           "புதிய வருகையை திட்டமிடவும்",  // ta
           "Lên lịch khám mới",  // vi
           "نئی ملاقات شیڈول کریں",  // ur
           "Programma nuova visita",  // it
           "กำหนดการเข้าพบใหม่",  // th
           "નવી મુલાકાત શેડ્યૂલ કરો",  // gu
           "Zaplanuj nową wizytę",  // pl
           "Запланувати новий візит",  // uk
           "برنامه‌ریزی ویزیت جدید",  // fa
           "Jadualkan lawatan baharu",  // ms
           "Programează o vizită nouă",  // ro
           "Nieuwe afspraak plannen"  // nl
        );

        public static LanguageText selectPatient = new LanguageText(
           "Select Patient",  // en
           "Επιλογή Ασθενούς",  // el
           "Seleccionar paciente",  // es
           "选择患者",  // zh
           "रोगी चुनें",  // hi
           "اختر المريض",  // ar
           "Selecionar paciente",  // pt
           "রোগী নির্বাচন করুন",  // bn
           "Выберите пациента",  // ru
           "患者を選択",  // jp
           "ਮਰੀਜ਼ ਚੁਣੋ",  // pa
           "Patient auswählen",  // de
           "Pilih pasien",  // jv
           "환자 선택",  // ko
           "Sélectionner un patient",  // fr
           "రోగిని ఎంచుకోండి",  // te
           "रुग्ण निवडा",  // mr
           "Hasta seç",  // tr
           "நோயாளியைத் தேர்ந்தெடுக்கவும்",  // ta
           "Chọn bệnh nhân",  // vi
           "مریض منتخب کریں",  // ur
           "Seleziona paziente",  // it
           "เลือกผู้ป่วย",  // th
           "દર્દી પસંદ કરો",  // gu
           "Wybierz pacjenta",  // pl
           "Виберіть пацієнта",  // uk
           "انتخاب بیمار",  // fa
           "Pilih pesakit",  // ms
           "Selectați pacientul",  // ro
           "Selecteer patiënt"  // nl
        );

        public static LanguageText appointmentDate = new LanguageText(
           "Appointment Date",  // en
           "Ημερομηνία Ραντεβού",  // el
           "Fecha de la cita",  // es
           "预约日期",  // zh
           "अपॉइंटमेंट तिथि",  // hi
           "تاريخ الموعد",  // ar
           "Data da consulta",  // pt
           "অ্যাপয়েন্টমেন্টের তারিখ",  // bn
           "Дата записи",  // ru
           "予約日",  // jp
           "ਮੁਲਾਕਾਤ ਦੀ ਤਾਰੀਖ",  // pa
           "Termin Datum",  // de
           "Tanggal janji",  // jv
           "예약 날짜",  // ko
           "Date du rendez-vous",  // fr
           "అపాయింట్‌మెంట్ తేదీ",  // te
           "अपॉइंटमेंट तारीख",  // mr
           "Randevu tarihi",  // tr
           "நியமன தேதி",  // ta
           "Ngày hẹn",  // vi
           "اپائنٹمنٹ کی تاریخ",  // ur
           "Data appuntamento",  // it
           "วันที่นัดหมาย",  // th
           "અપોઇન્ટમેન્ટ તારીખ",  // gu
           "Data wizyty",  // pl
           "Дата запису",  // uk
           "تاریخ نوبت",  // fa
           "Tarikh janji temu",  // ms
           "Data programării",  // ro
           "Afspraakdatum"  // nl
        );

        public static LanguageText appointmentTimeDuration = new LanguageText(
           "Appointment Time & Duration",  // en
           "Ώρα & Διάρκεια Ραντεβού",  // el
           "Hora y duración de la cita",  // es
           "预约时间和时长",  // zh
           "समय और अवधि",  // hi
           "وقت ومدة الموعد",  // ar
           "Hora e duração da consulta",  // pt
           "সময় ও সময়কাল",  // bn
           "Время и длительность",  // ru
           "時間と期間",  // jp
           "ਸਮਾਂ ਅਤੇ ਮਿਆਦ",  // pa
           "Zeit & Dauer",  // de
           "Wektu lan durasi",  // jv
           "시간 및 기간",  // ko
           "Heure et durée",  // fr
           "సమయం & వ్యవధి",  // te
           "वेळ आणि कालावधी",  // mr
           "Saat ve süre",  // tr
           "நேரம் மற்றும் காலம்",  // ta
           "Thời gian & thời lượng",  // vi
           "وقت اور دورانیہ",  // ur
           "Orario e durata",  // it
           "เวลาและระยะเวลา",  // th
           "સમય અને અવધિ",  // gu
           "Czas i czas trwania",  // pl
           "Час і тривалість",  // uk
           "زمان و مدت",  // fa
           "Masa & tempoh",  // ms
           "Ora și durată",  // ro
           "Tijd en duur"  // nl
        );

        public static LanguageText visitReason = new LanguageText(
           "Visit Reason",  // en
           "Αιτία Επίσκεψης",  // el
           "Motivo de la visita",  // es
           "就诊原因",  // zh
           "भेंट का कारण",  // hi
           "سبب الزيارة",  // ar
           "Motivo da visita",  // pt
           "ভিজিটের কারণ",  // bn
           "Причина визита",  // ru
           "来院理由",  // jp
           "ਮੁਲਾਕਾਤ ਦਾ ਕਾਰਨ",  // pa
           "Besuchsgrund",  // de
           "Alasan kunjungan",  // jv
           "방문 이유",  // ko
           "Motif de la visite",  // fr
           "సందర్శన కారణం",  // te
           "भेटीचे कारण",  // mr
           "Ziyaret nedeni",  // tr
           "வருகை காரணம்",  // ta
           "Lý do khám",  // vi
           "ملاقات کی وجہ",  // ur
           "Motivo della visita",  // it
           "เหตุผลในการเข้าพบ",  // th
           "મુલાકાતનું કારણ",  // gu
           "Powód wizyty",  // pl
           "Причина візиту",  // uk
           "دلیل مراجعه",  // fa
           "Sebab lawatan",  // ms
           "Motivul vizitei",  // ro
           "Reden van bezoek"  // nl
        );

        public static LanguageText availabilityCheck = new LanguageText(
           "Availability Check",  // en
           "Έλεγχος Διαθεσιμότητας",  // el
           "Verificar disponibilidad",  // es
           "可用性检查",  // zh
           "उपलब्धता जांच",  // hi
           "التحقق من التوفر",  // ar
           "Verificação de disponibilidade",  // pt
           "উপলব্ধতা যাচাই",  // bn
           "Проверка доступности",  // ru
           "空き状況の確認",  // jp
           "ਉਪਲਬਧਤਾ ਜਾਂਚ",  // pa
           "Verfügbarkeitsprüfung",  // de
           "Mriksa kasedhiyan",  // jv
           "가용성 확인",  // ko
           "Vérification de disponibilité",  // fr
           "లభ్యత తనిఖీ",  // te
           "उपलब्धता तपासा",  // mr
           "Uygunluk kontrolü",  // tr
           "கிடைக்கும் நிலை சரிபார்ப்பு",  // ta
           "Kiểm tra khả dụng",  // vi
           "دستیابی کی جانچ",  // ur
           "Verifica disponibilità",  // it
           "ตรวจสอบความพร้อมใช้งาน",  // th
           "ઉપલબ્ધતા ચકાસણી",  // gu
           "Sprawdź dostępność",  // pl
           "Перевірка доступності",  // uk
           "بررسی دسترسی",  // fa
           "Semakan ketersediaan",  // ms
           "Verificare disponibilitate",  // ro
           "Beschikbaarheidscontrole"  // nl
        );

        public static LanguageText unavailableFrom = new LanguageText(
           "Unavailable from",  // en
           "Μη διαθέσιμο από",  // el
           "No disponible desde",  // es
           "从此时间不可用",  // zh
           "से उपलब्ध नहीं",  // hi
           "غير متاح من",  // ar
           "Indisponível a partir de",  // pt
           "এই সময় থেকে অনুপলব্ধ",  // bn
           "Недоступно с",  // ru
           "この時間から利用不可",  // jp
           "ਤੋਂ ਉਪਲਬਧ ਨਹੀਂ",  // pa
           "Nicht verfügbar ab",  // de
           "Ora kasedhiya saka",  // jv
           "이 시간부터 사용 불가",  // ko
           "Indisponible à partir de",  // fr
           "నుండి అందుబాటులో లేదు",  // te
           "पासून उपलब्ध नाही",  // mr
           "Şu saatten itibaren uygun değil",  // tr
           "இந்த நேரத்திலிருந்து கிடைக்காது",  // ta
           "Không khả dụng từ",  // vi
           "سے دستیاب نہیں",  // ur
           "Non disponibile da",  // it
           "ไม่ว่างตั้งแต่",  // th
           "થી ઉપલબ્ધ નથી",  // gu
           "Niedostępne od",  // pl
           "Недоступно з",  // uk
           "از این زمان در دسترس نیست",  // fa
           "Tidak tersedia dari",  // ms
           "Indisponibil de la",  // ro
           "Niet beschikbaar vanaf"  // nl
        );

        public static LanguageText availableFrom = new LanguageText(
           "Available from",  // en
           "Διαθέσιμο από",  // el
           "Disponible desde",  // es
           "从此时间可用",  // zh
           "से उपलब्ध",  // hi
           "متاح من",  // ar
           "Disponível a partir de",  // pt
           "এই সময় থেকে উপলব্ধ",  // bn
           "Доступно с",  // ru
           "この時間から利用可能",  // jp
           "ਤੋਂ ਉਪਲਬਧ",  // pa
           "Verfügbar ab",  // de
           "Kasedhiya saka",  // jv
           "이 시간부터 사용 가능",  // ko
           "Disponible à partir de",  // fr
           "నుండి అందుబాటులో ఉంది",  // te
           "पासून उपलब्ध",  // mr
           "Şu saatten itibaren uygun",  // tr
           "இந்த நேரத்திலிருந்து கிடைக்கும்",  // ta
           "Có sẵn từ",  // vi
           "سے دستیاب",  // ur
           "Disponibile da",  // it
           "ว่างตั้งแต่",  // th
           "થી ઉપલબ્ધ",  // gu
           "Dostępne od",  // pl
           "Доступно з",  // uk
           "از این زمان در دسترس",  // fa
           "Tersedia dari",  // ms
           "Disponibil de la",  // ro
           "Beschikbaar vanaf"  // nl
        );

        public static LanguageText oneHour = new LanguageText(
           "1 Hour", "1 Ώρα", "1 hora", "1小时", "1 घंटा", "ساعة واحدة", "1 hora", "১ ঘন্টা", "1 час", "1時間", "1 ਘੰਟਾ", "1 Stunde", "1 jam", "1시간", "1 heure", "1 గంట", "1 तास", "1 saat", "1 மணி", "1 giờ", "1 گھنٹہ", "1 ora", "1 ชั่วโมง", "1 કલાક", "1 godzina", "1 година", "1 ساعت", "1 jam", "1 oră", "1 uur"
        );

        public static LanguageText fortyFiveMin = new LanguageText(
           "45 Minutes", "45 λεπτά", "45 minutos", "45分钟", "45 मिनट", "45 دقيقة", "45 minutos", "৪৫ মিনিট", "45 минут", "45分", "45 ਮਿੰਟ", "45 Minuten", "45 menit", "45분", "45 minutes", "45 నిమిషాలు", "45 मिनिटे", "45 dakika", "45 நிமிடங்கள்", "45 phút", "45 منٹ", "45 minuti", "45 นาที", "45 મિનિટ", "45 minut", "45 хвилин", "45 دقیقه", "45 minit", "45 minute", "45 minuten"
        );

        public static LanguageText thirtyMin = new LanguageText(
           "30 Minutes", "30 λεπτά", "30 minutos", "30分钟", "30 मिनट", "30 دقيقة", "30 minutos", "৩০ মিনিট", "30 минут", "30分", "30 ਮਿੰਟ", "30 Minuten", "30 menit", "30분", "30 minutes", "30 నిమిషాలు", "30 मिनिटे", "30 dakika", "30 நிமிடங்கள்", "30 phút", "30 منٹ", "30 minuti", "30 นาที", "30 મિનિટ", "30 minut", "30 хвилин", "30 دقیقه", "30 minit", "30 minute", "30 minuten"
        );

        public static LanguageText twentyMin = new LanguageText(
           "20 Minutes", "20 λεπτά", "20 minutos", "20分钟", "20 मिनट", "20 دقيقة", "20 minutos", "২০ মিনিট", "20 минут", "20分", "20 ਮਿੰਟ", "20 Minuten", "20 menit", "20분", "20 minutes", "20 నిమిషాలు", "20 मिनिटे", "20 dakika", "20 நிமிடங்கள்", "20 phút", "20 منٹ", "20 minuti", "20 นาที", "20 મિનિટ", "20 minut", "20 хвилин", "20 دقیقه", "20 minit", "20 minute", "20 minuten"
        );

        public static LanguageText fifteenMin = new LanguageText(
           "15 Minutes", "15 λεπτά", "15 minutos", "15分钟", "15 मिनट", "15 دقيقة", "15 minutos", "১৫ মিনিট", "15 минут", "15分", "15 ਮਿੰਟ", "15 Minuten", "15 menit", "15분", "15 minutes", "15 నిమిషాలు", "15 मिनिटे", "15 dakika", "15 நிமிடங்கள்", "15 phút", "15 منٹ", "15 minuti", "15 นาที", "15 મિનિટ", "15 minut", "15 хвилин", "15 دقیقه", "15 minit", "15 minute", "15 minuten"
        );

        public static LanguageText tenMin = new LanguageText(
           "10 Minutes", "10 λεπτά", "10 minutos", "10分钟", "10 मिनट", "10 دقيقة", "10 minutos", "১০ মিনিট", "10 минут", "10分", "10 ਮਿੰਟ", "10 Minuten", "10 menit", "10분", "10 minutes", "10 నిమిషాలు", "10 मिनिटे", "10 dakika", "10 நிமிடங்கள்", "10 phút", "10 منٹ", "10 minuti", "10 นาที", "10 મિનિટ", "10 minut", "10 хвилин", "10 دقیقه", "10 minit", "10 minute", "10 minuten"
        );

        public static LanguageText dailyTimeline = new LanguageText(
           "Daily Timeline",  // en
           "Ημερήσιο Χρονοδιάγραμμα",  // el
           "Cronograma diario",  // es
           "每日时间线",  // zh
           "दैनिक समयरेखा",  // hi
           "الجدول اليومي",  // ar
           "Linha do tempo diária",  // pt
           "দৈনিক টাইমলাইন",  // bn
           "Ежедневная хронология",  // ru
           "日次タイムライン",  // jp
           "ਰੋਜ਼ਾਨਾ ਟਾਈਮਲਾਈਨ",  // pa
           "Tägliche Zeitleiste",  // de
           "Timeline saben dina",  // jv
           "일일 타임라인",  // ko
           "Chronologie quotidienne",  // fr
           "దైనందిన టైమ్‌లైన్",  // te
           "दैनिक टाइमलाइन",  // mr
           "Günlük zaman çizelgesi",  // tr
           "தினசரி காலவரிசை",  // ta
           "Dòng thời gian hàng ngày",  // vi
           "روزانہ ٹائم لائن",  // ur
           "Cronologia giornaliera",  // it
           "ไทม์ไลน์รายวัน",  // th
           "દૈનિક ટાઇમલાઇન",  // gu
           "Oś czasu dzienna",  // pl
           "Щоденна хронологія",  // uk
           "خط زمانی روزانه",  // fa
           "Garis masa harian",  // ms
           "Cronologie zilnică",  // ro
           "Dagelijkse tijdlijn"  // nl
        );

      

        public static LanguageText editAppointment = new LanguageText(
           "Edit Appointment",  // en
           "Επεξεργασία Ραντεβού",  // el
           "Editar cita",  // es
           "编辑预约",  // zh
           "अपॉइंटमेंट संपादित करें",  // hi
           "تعديل الموعد",  // ar
           "Editar consulta",  // pt
           "অ্যাপয়েন্টমেন্ট সম্পাদনা করুন",  // bn
           "Редактировать запись",  // ru
           "予約を編集",  // jp
           "ਮੁਲਾਕਾਤ ਸੋਧੋ",  // pa
           "Termin bearbeiten",  // de
           "Edit janji",  // jv
           "예약 수정",  // ko
           "Modifier le rendez-vous",  // fr
           "అపాయింట్‌మెంట్ సవరించు",  // te
           "अपॉइंटमेंट संपादित करा",  // mr
           "Randevuyu düzenle",  // tr
           "நியமனத்தை திருத்து",  // ta
           "Chỉnh sửa cuộc hẹn",  // vi
           "اپائنٹمنٹ میں ترمیم کریں",  // ur
           "Modifica appuntamento",  // it
           "แก้ไขการนัดหมาย",  // th
           "અપોઇન્ટમેન્ટ સંપાદિત કરો",  // gu
           "Edytuj wizytę",  // pl
           "Редагувати запис",  // uk
           "ویرایش نوبت",  // fa
           "Edit janji temu",  // ms
           "Editează programarea",  // ro
           "Afspraak bewerken"  // nl
        );



        public static LanguageText welcomeBack = new LanguageText(
   "Welcome Back",  // en
   "Καλώς ήρθατε ξανά",  // el
   "Bienvenido de nuevo",  // es
   "欢迎回来",  // zh
   "वापसी पर स्वागत है",  // hi
   "مرحبًا بعودتك",  // ar
   "Bem-vindo de volta",  // pt
   "ফিরে আসায় স্বাগতম",  // bn
   "С возвращением",  // ru
   "おかえりなさい",  // jp
   "ਵਾਪਸੀ 'ਤੇ ਸੁਆਗਤ ਹੈ",  // pa
   "Willkommen zurück",  // de
   "Sugeng rawuh maneh",  // jv
   "다시 오신 것을 환영합니다",  // ko
   "Bon retour",  // fr
   "తిరిగి స్వాగతం",  // te
   "परत स्वागत आहे",  // mr
   "Tekrar hoş geldiniz",  // tr
   "மீண்டும் வரவேற்கிறோம்",  // ta
   "Chào mừng trở lại",  // vi
   "واپسی پر خوش آمدید",  // ur
   "Bentornato",  // it
   "ยินดีต้อนรับกลับ",  // th
   "ફરી સ્વાગત છે",  // gu
   "Witamy ponownie",  // pl
   "З поверненням",  // uk
   "خوش برگشتی",  // fa
   "Selamat kembali",  // ms
   "Bine ai revenit",  // ro
   "Welkom terug"  // nl
);

        public static LanguageText loginAccess = new LanguageText(
           "Please login to access patient data",  // en
           "Παρακαλώ συνδεθείτε για πρόσβαση στα δεδομένα ασθενών",  // el
           "Inicie sesión para acceder a los datos del paciente",  // es
           "请登录以访问患者数据",  // zh
           "रोगी डेटा तक पहुँचने के लिए लॉगिन करें",  // hi
           "يرجى تسجيل الدخول للوصول إلى بيانات المريض",  // ar
           "Faça login para acessar os dados do paciente",  // pt
           "রোগীর তথ্য দেখতে লগইন করুন",  // bn
           "Войдите, чтобы получить доступ к данным пациента",  // ru
           "患者データにアクセスするにはログインしてください",  // jp
           "ਮਰੀਜ਼ ਡਾਟਾ ਲਈ ਲੌਗਇਨ ਕਰੋ",  // pa
           "Bitte melden Sie sich an, um auf Patientendaten zuzugreifen",  // de
           "Mangga mlebu kanggo ngakses data pasien",  // jv
           "환자 데이터에 접근하려면 로그인하세요",  // ko
           "Veuillez vous connecter pour accéder aux données du patient",  // fr
           "రోగి డేటా యాక్సెస్ చేయడానికి లాగిన్ చేయండి",  // te
           "रुग्ण डेटा पाहण्यासाठी लॉगिन करा",  // mr
           "Hasta verilerine erişmek için giriş yapın",  // tr
           "நோயாளர் தரவை அணுக உள்நுழைக",  // ta
           "Vui lòng đăng nhập để truy cập dữ liệu bệnh nhân",  // vi
           "مریض کے ڈیٹا تک رسائی کے لیے لاگ ان کریں",  // ur
           "Accedi per visualizzare i dati del paziente",  // it
           "กรุณาเข้าสู่ระบบเพื่อเข้าถึงข้อมูลผู้ป่วย",  // th
           "દર્દીના ડેટા માટે લોગિન કરો",  // gu
           "Zaloguj się, aby uzyskać dostęp do danych pacjenta",  // pl
           "Увійдіть, щоб отримати доступ до даних пацієнта",  // uk
           "برای دسترسی به داده‌های بیمار وارد شوید",  // fa
           "Log masuk untuk akses data pesakit",  // ms
           "Autentificați-vă pentru a accesa datele pacientului",  // ro
           "Log in om patiëntgegevens te bekijken"  // nl
        );

        public static LanguageText login = new LanguageText(
           "Login", "Σύνδεση", "Iniciar sesión", "登录", "लॉगिन", "تسجيل الدخول", "Entrar", "লগইন", "Вход", "ログイン", "ਲੌਗਇਨ", "Anmelden", "Mlebu", "로그인", "Connexion", "లాగిన్", "लॉगिन", "Giriş", "உள்நுழை", "Đăng nhập", "لاگ ان", "Accesso", "เข้าสู่ระบบ", "લોગિન", "Zaloguj się", "Увійти", "ورود", "Log masuk", "Autentificare", "Inloggen"
        );

        public static LanguageText createAccount = new LanguageText(
           "Create Account",  // en
           "Δημιουργία Λογαριασμού",  // el
           "Crear cuenta",  // es
           "创建账户",  // zh
           "खाता बनाएं",  // hi
           "إنشاء حساب",  // ar
           "Criar conta",  // pt
           "অ্যাকাউন্ট তৈরি করুন",  // bn
           "Создать аккаунт",  // ru
           "アカウント作成",  // jp
           "ਖਾਤਾ ਬਣਾਓ",  // pa
           "Konto erstellen",  // de
           "Gawe akun",  // jv
           "계정 만들기",  // ko
           "Créer un compte",  // fr
           "ఖాతా సృష్టించండి",  // te
           "खाते तयार करा",  // mr
           "Hesap oluştur",  // tr
           "கணக்கு உருவாக்கு",  // ta
           "Tạo tài khoản",  // vi
           "اکاؤنٹ بنائیں",  // ur
           "Crea account",  // it
           "สร้างบัญชี",  // th
           "એકાઉન્ટ બનાવો",  // gu
           "Utwórz konto",  // pl
           "Створити акаунт",  // uk
           "ایجاد حساب",  // fa
           "Cipta akaun",  // ms
           "Creează cont",  // ro
           "Account aanmaken"  // nl
        );

        public static LanguageText setupCredentials = new LanguageText(
           "Set up your master credentials",  // en
           "Ρυθμίστε τα κύρια διαπιστευτήριά σας",  // el
           "Configure sus credenciales maestras",  // es
           "设置您的主凭据",  // zh
           "अपने मुख्य क्रेडेंशियल सेट करें",  // hi
           "قم بإعداد بيانات الاعتماد الرئيسية",  // ar
           "Configure suas credenciais principais",  // pt
           "আপনার প্রধান ক্রেডেনশিয়াল সেট করুন",  // bn
           "Настройте основные учетные данные",  // ru
           "マスター認証情報を設定してください",  // jp
           "ਆਪਣੇ ਮੁੱਖ ਪ੍ਰਮਾਣ ਪੱਤਰ ਸੈਟ ਕਰੋ",  // pa
           "Richten Sie Ihre Hauptanmeldedaten ein",  // de
           "Atur kredensial utama",  // jv
           "마스터 자격 증명 설정",  // ko
           "Configurez vos identifiants principaux",  // fr
           "మీ ప్రధాన క్రెడెన్షియల్స్ సెట్ చేయండి",  // te
           "मुख्य क्रेडेन्शियल सेट करा",  // mr
           "Ana kimlik bilgilerinizi ayarlayın",  // tr
           "உங்கள் முதன்மை சான்றுகளை அமைக்கவும்",  // ta
           "Thiết lập thông tin đăng nhập chính",  // vi
           "اپنے مرکزی اسناد سیٹ کریں",  // ur
           "Configura le credenziali principali",  // it
           "ตั้งค่าข้อมูลรับรองหลัก",  // th
           "તમારા મુખ્ય ક્રેડેન્શિયલ સેટ કરો",  // gu
           "Ustaw dane logowania główne",  // pl
           "Налаштуйте основні облікові дані",  // uk
           "تنظیم اطلاعات ورود اصلی",  // fa
           "Sediakan kelayakan utama",  // ms
           "Configurați acreditările principale",  // ro
           "Stel je hoofdgegevens in"  // nl
        );

        public static LanguageText createInitialize = new LanguageText(
           "Create and Initialize",  // en
           "Δημιουργία και Αρχικοποίηση",  // el
           "Crear e inicializar",  // es
           "创建并初始化",  // zh
           "बनाएं और प्रारंभ करें",  // hi
           "إنشاء وتهيئة",  // ar
           "Criar e inicializar",  // pt
           "তৈরি ও শুরু করুন",  // bn
           "Создать и инициализировать",  // ru
           "作成して初期化",  // jp
           "ਬਣਾਓ ਅਤੇ ਸ਼ੁਰੂ ਕਰੋ",  // pa
           "Erstellen und initialisieren",  // de
           "Gawe lan inisialisasi",  // jv
           "생성 및 초기화",  // ko
           "Créer et initialiser",  // fr
           "సృష్టించండి మరియు ప్రారంభించండి",  // te
           "तयार करा आणि प्रारंभ करा",  // mr
           "Oluştur ve başlat",  // tr
           "உருவாக்கி தொடங்கு",  // ta
           "Tạo và khởi tạo",  // vi
           "بنائیں اور شروع کریں",  // ur
           "Crea e inizializza",  // it
           "สร้างและเริ่มต้น",  // th
           "બનાવો અને પ્રારંભ કરો",  // gu
           "Utwórz i zainicjuj",  // pl
           "Створити та ініціалізувати",  // uk
           "ایجاد و راه‌اندازی",  // fa
           "Cipta dan mulakan",  // ms
           "Creează și inițializează",  // ro
           "Aanmaken en initialiseren"  // nl
        );

        public static LanguageText fillAllFields = new LanguageText(
           "Please fill in all fields.",  // en
           "Παρακαλώ συμπληρώστε όλα τα πεδία.",  // el
           "Por favor complete todos los campos.",  // es
           "请填写所有字段。",  // zh
           "कृपया सभी फ़ील्ड भरें।",  // hi
           "يرجى ملء جميع الحقول.",  // ar
           "Por favor, preencha todos os campos.",  // pt
           "অনুগ্রহ করে সব ঘর পূরণ করুন।",  // bn
           "Пожалуйста, заполните все поля.",  // ru
           "すべての項目を入力してください。",  // jp
           "ਕਿਰਪਾ ਕਰਕੇ ਸਾਰੇ ਖੇਤਰ ਭਰੋ।",  // pa
           "Bitte füllen Sie alle Felder aus.",  // de
           "Isi kabeh kolom.",  // jv
           "모든 필드를 입력하세요.",  // ko
           "Veuillez remplir tous les champs.",  // fr
           "దయచేసి అన్ని ఫీల్డ్‌లు నింపండి.",  // te
           "कृपया सर्व फील्ड भरा.",  // mr
           "Lütfen tüm alanları doldurun.",  // tr
           "அனைத்து புலங்களையும் நிரப்பவும்.",  // ta
           "Vui lòng điền tất cả các trường.",  // vi
           "براہ کرم تمام خانے بھریں۔",  // ur
           "Compila tutti i campi.",  // it
           "กรุณากรอกข้อมูลให้ครบทุกช่อง",  // th
           "કૃપા કરીને બધા ક્ષેત્રો ભરો.",  // gu
           "Proszę wypełnić wszystkie pola.",  // pl
           "Будь ласка, заповніть усі поля.",  // uk
           "لطفاً همه فیلدها را پر کنید.",  // fa
           "Sila isi semua medan.",  // ms
           "Vă rugăm să completați toate câmpurile.",  // ro
           "Vul alle velden in."  // nl
        );

        public static LanguageText accountCreated = new LanguageText(
           "Account created! Please remember your password.",  // en
           "Ο λογαριασμός δημιουργήθηκε! Παρακαλώ θυμηθείτε τον κωδικό σας.",  // el
           "¡Cuenta creada! Recuerde su contraseña.",  // es
           "账户已创建！请记住您的密码。",  // zh
           "खाता बन गया! कृपया अपना पासवर्ड याद रखें।",  // hi
           "تم إنشاء الحساب! يرجى تذكر كلمة المرور.",  // ar
           "Conta criada! Lembre-se da sua senha.",  // pt
           "অ্যাকাউন্ট তৈরি হয়েছে! আপনার পাসওয়ার্ড মনে রাখুন।",  // bn
           "Аккаунт создан! Запомните пароль.",  // ru
           "アカウントが作成されました！パスワードを忘れないでください。",  // jp
           "ਖਾਤਾ ਬਣ ਗਿਆ! ਆਪਣਾ ਪਾਸਵਰਡ ਯਾਦ ਰੱਖੋ।",  // pa
           "Konto erstellt! Bitte merken Sie sich Ihr Passwort.",  // de
           "Akun digawe! Elinga sandhi sampeyan.",  // jv
           "계정이 생성되었습니다! 비밀번호를 기억하세요.",  // ko
           "Compte créé ! N'oubliez pas votre mot de passe.",  // fr
           "ఖాతా సృష్టించబడింది! దయచేసి మీ పాస్‌వర్డ్ గుర్తుంచుకోండి.",  // te
           "खाते तयार झाले! पासवर्ड लक्षात ठेवा.",  // mr
           "Hesap oluşturuldu! Şifrenizi unutmayın.",  // tr
           "கணக்கு உருவாக்கப்பட்டது! கடவுச்சொல்லை நினைவில் கொள்ளுங்கள்.",  // ta
           "Tài khoản đã được tạo! Hãy nhớ mật khẩu.",  // vi
           "اکاؤنٹ بن گیا! پاس ورڈ یاد رکھیں۔",  // ur
           "Account creato! Ricorda la password.",  // it
           "สร้างบัญชีแล้ว! โปรดจำรหัสผ่านของคุณ",  // th
           "એકાઉન્ટ બનાવાયું! પાસવર્ડ યાદ રાખો.",  // gu
           "Konto utworzone! Zapamiętaj hasło.",  // pl
           "Акаунт створено! Запам’ятайте пароль.",  // uk
           "حساب ایجاد شد! رمز عبور را به خاطر بسپارید.",  // fa
           "Akaun dicipta! Ingat kata laluan anda.",  // ms
           "Cont creat! Vă rugăm să rețineți parola.",  // ro
           "Account aangemaakt! Onthoud je wachtwoord."  // nl
        );

        public static LanguageText invalidUsername = new LanguageText(
           "Invalid Username.",  // en
           "Μη έγκυρο όνομα χρήστη.",  // el
           "Nombre de usuario no válido.",  // es
           "用户名无效。",  // zh
           "अमान्य उपयोगकर्ता नाम।",  // hi
           "اسم المستخدم غير صالح.",  // ar
           "Nome de usuário inválido.",  // pt
           "অবৈধ ব্যবহারকারীর নাম।",  // bn
           "Неверное имя пользователя.",  // ru
           "無効なユーザー名です。",  // jp
           "ਗਲਤ ਯੂਜ਼ਰਨਾਮ।",  // pa
           "Ungültiger Benutzername.",  // de
           "Jeneng pangguna ora sah.",  // jv
           "잘못된 사용자 이름입니다.",  // ko
           "Nom d'utilisateur invalide.",  // fr
           "చెల్లని యూజర్‌నేమ్.",  // te
           "अवैध वापरकर्ता नाव.",  // mr
           "Geçersiz kullanıcı adı.",  // tr
           "தவறான பயனர் பெயர்.",  // ta
           "Tên người dùng không hợp lệ.",  // vi
           "غلط صارف نام۔",  // ur
           "Nome utente non valido.",  // it
           "ชื่อผู้ใช้ไม่ถูกต้อง",  // th
           "અમાન્ય યુઝરનેમ.",  // gu
           "Nieprawidłowa nazwa użytkownika.",  // pl
           "Неправильне ім’я користувача.",  // uk
           "نام کاربری نامعتبر است.",  // fa
           "Nama pengguna tidak sah.",  // ms
           "Nume de utilizator invalid.",  // ro
           "Ongeldige gebruikersnaam."  // nl
        );

        public static LanguageText invalidPassword = new LanguageText(
           "Invalid Password.",  // en
           "Μη έγκυρος κωδικός.",  // el
           "Contraseña no válida.",  // es
           "密码无效。",  // zh
           "अमान्य पासवर्ड।",  // hi
           "كلمة المرور غير صالحة.",  // ar
           "Senha inválida.",  // pt
           "অবৈধ পাসওয়ার্ড।",  // bn
           "Неверный пароль.",  // ru
           "無効なパスワードです。",  // jp
           "ਗਲਤ ਪਾਸਵਰਡ।",  // pa
           "Ungültiges Passwort.",  // de
           "Sandhi ora sah.",  // jv
           "잘못된 비밀번호입니다.",  // ko
           "Mot de passe invalide.",  // fr
           "చెల్లని పాస్‌వర్డ్.",  // te
           "अवैध पासवर्ड.",  // mr
           "Geçersiz şifre.",  // tr
           "தவறான கடவுச்சொல்.",  // ta
           "Mật khẩu không hợp lệ.",  // vi
           "غلط پاس ورڈ۔",  // ur
           "Password non valida.",  // it
           "รหัสผ่านไม่ถูกต้อง",  // th
           "અમાન્ય પાસવર્ડ.",  // gu
           "Nieprawidłowe hasło.",  // pl
           "Неправильний пароль.",  // uk
           "رمز عبور نامعتبر است.",  // fa
           "Kata laluan tidak sah.",  // ms
           "Parolă invalidă.",  // ro
           "Ongeldig wachtwoord."  // nl
        );

        public static LanguageText usernameNotFound = new LanguageText(
           "Username not found or file corrupted.",  // en
           "Το όνομα χρήστη δεν βρέθηκε ή το αρχείο είναι κατεστραμμένο.",  // el
           "Nombre de usuario no encontrado o archivo dañado.",  // es
           "未找到用户名或文件已损坏。",  // zh
           "उपयोगकर्ता नाम नहीं मिला या फ़ाइल क्षतिग्रस्त है।",  // hi
           "اسم المستخدم غير موجود أو الملف تالف.",  // ar
           "Nome de usuário não encontrado ou arquivo corrompido.",  // pt
           "ব্যবহারকারীর নাম পাওয়া যায়নি বা ফাইল নষ্ট।",  // bn
           "Имя пользователя не найдено или файл поврежден.",  // ru
           "ユーザー名が見つからないか、ファイルが破損しています。",  // jp
           "ਯੂਜ਼ਰਨਾਮ ਨਹੀਂ ਮਿਲਿਆ ਜਾਂ ਫਾਈਲ ਖਰਾਬ ਹੈ।",  // pa
           "Benutzername nicht gefunden oder Datei beschädigt.",  // de
           "Jeneng pangguna ora ditemokake utawa file rusak.",  // jv
           "사용자 이름을 찾을 수 없거나 파일이 손상되었습니다.",  // ko
           "Nom d'utilisateur introuvable ou fichier corrompu.",  // fr
           "యూజర్‌నేమ్ కనబడలేదు లేదా ఫైల్ దెబ్బతింది.",  // te
           "वापरकर्ता नाव सापडले नाही किंवा फाइल खराब आहे.",  // mr
           "Kullanıcı adı bulunamadı veya dosya bozuk.",  // tr
           "பயனர் பெயர் கிடைக்கவில்லை அல்லது கோப்பு சேதமடைந்துள்ளது.",  // ta
           "Không tìm thấy tên người dùng hoặc tệp bị hỏng.",  // vi
           "صارف نام نہیں ملا یا فائل خراب ہے۔",  // ur
           "Nome utente non trovato o file corrotto.",  // it
           "ไม่พบชื่อผู้ใช้หรือไฟล์เสียหาย",  // th
           "યુઝરનેમ મળ્યું નથી અથવા ફાઇલ ખરાબ છે.",  // gu
           "Nie znaleziono nazwy użytkownika lub plik uszkodzony.",  // pl
           "Ім’я користувача не знайдено або файл пошкоджений.",  // uk
           "نام کاربری یافت نشد یا فایل خراب است.",  // fa
           "Nama pengguna tidak dijumpai atau fail rosak.",  // ms
           "Nume de utilizator negăsit sau fișier corupt.",  // ro
           "Gebruikersnaam niet gevonden of bestand beschadigd."  // nl
        );

        public static LanguageText important = new LanguageText(
           "IMPORTANT:",  // en
           "ΣΗΜΑΝΤΙΚΟ:",  // el
           "IMPORTANTE:",  // es
           "重要：",  // zh
           "महत्वपूर्ण:",  // hi
           "مهم:",  // ar
           "IMPORTANTE:",  // pt
           "গুরুত্বপূর্ণ:",  // bn
           "ВАЖНО:",  // ru
           "重要:",  // jp
           "ਮਹੱਤਵਪੂਰਨ:",  // pa
           "WICHTIG:",  // de
           "PENTING:",  // jv
           "중요:",  // ko
           "IMPORTANT :",  // fr
           "ముఖ్యమైనది:",  // te
           "महत्त्वाचे:",  // mr
           "ÖNEMLİ:",  // tr
           "முக்கியம்:",  // ta
           "QUAN TRỌNG:",  // vi
           "اہم:",  // ur
           "IMPORTANTE:",  // it
           "สำคัญ:",  // th
           "મહત્વપૂર્ણ:",  // gu
           "WAŻNE:",  // pl
           "ВАЖЛИВО:",  // uk
           "مهم:",  // fa
           "PENTING:",  // ms
           "IMPORTANT:",  // ro
           "BELANGRIJK:"  // nl
        );
        public static LanguageText communityUser = new LanguageText(
   "Community user",  // en
   "Χρήστης κοινότητας",  // el
   "Usuario de la comunidad",  // es
   "社区用户",  // zh
   "समुदाय उपयोगकर्ता",  // hi
   "مستخدم المجتمع",  // ar
   "Usuário da comunidade",  // pt
   "কমিউনিটি ব্যবহারকারী",  // bn
   "Пользователь сообщества",  // ru
   "コミュニティユーザー",  // jp
   "ਕਮਿਊਨਿਟੀ ਯੂਜ਼ਰ",  // pa
   "Community-Benutzer",  // de
   "Pangguna komunitas",  // jv
   "커뮤니티 사용자",  // ko
   "Utilisateur de la communauté",  // fr
   "కమ్యూనిటీ వినియోగదారు",  // te
   "समुदाय वापरकर्ता",  // mr
   "Topluluk kullanıcısı",  // tr
   "சமூக பயனர்",  // ta
   "Người dùng cộng đồng",  // vi
   "کمیونٹی صارف",  // ur
   "Utente della comunità",  // it
   "ผู้ใช้ชุมชน",  // th
   "સમુદાય વપરાશકર્તા",  // gu
   "Użytkownik społeczności",  // pl
   "Користувач спільноти",  // uk
   "کاربر جامعه",  // fa
   "Pengguna komuniti",  // ms
   "Utilizator comunitate",  // ro
   "Communitygebruiker"  // nl
);
        public static LanguageText systemOverview = new LanguageText(
   "System Overview",  // en
   "Επισκόπηση Συστήματος",  // el
   "Resumen del sistema",  // es
   "系统概览",  // zh
   "सिस्टम अवलोकन",  // hi
   "نظرة عامة على النظام",  // ar
   "Visão geral do sistema",  // pt
   "সিস্টেম ওভারভিউ",  // bn
   "Обзор системы",  // ru
   "システム概要",  // jp
   "ਸਿਸਟਮ ਝਲਕ",  // pa
   "Systemübersicht",  // de
   "Ringkesan sistem",  // jv
   "시스템 개요",  // ko
   "Aperçu du système",  // fr
   "సిస్టమ్ అవలోకనం",  // te
   "सिस्टम आढावा",  // mr
   "Sistem genel bakış",  // tr
   "அமைப்பு கண்ணோட்டம்",  // ta
   "Tổng quan hệ thống",  // vi
   "سسٹم کا جائزہ",  // ur
   "Panoramica del sistema",  // it
   "ภาพรวมระบบ",  // th
   "સિસ્ટમ અવલોકન",  // gu
   "Przegląd systemu",  // pl
   "Огляд системи",  // uk
   "نمای کلی سیستم",  // fa
   "Gambaran keseluruhan sistem",  // ms
   "Prezentare generală a sistemului",  // ro
   "Systeemoverzicht"  // nl
);
        public static LanguageText LngSub = new LanguageText(
           "En",
           "El",
           "Es",  
           "Zh",
           "Hi",  // hi
           "Ar",  // ar
           "Pt",  // pt
           "Bn",  // bn
           "Ru",  // ru
           "Jp",  // jp
           "Pa",  // pa
           "De",  // de
           "Fv",  // jv
           "Ko",  // ko
           "Fr",  // fr
           "Te",  // te
           "Mr",  // mr
           "Tr",  // tr
           "Ta",  // ta
           "Vi",  // vi
           "Ur",  // ur
           "It",  // it
           "Th",  // th
           "Gu",  // gu
           "Pl",  // pl
           "Uk",  // uk
           "Fa",  // fa
           "Ms",  // ms
           "Ro",  // ro
           "Nl"  // nl
        );

        public static LanguageText passwordWarning = new LanguageText(
           "Lost passwords cannot be recovered by the developer. Your data is encrypted locally using this password.",  // en
           "Οι χαμένοι κωδικοί δεν μπορούν να ανακτηθούν από τον προγραμματιστή. Τα δεδομένα σας είναι κρυπτογραφημένα τοπικά με αυτόν τον κωδικό.",  // el
           "Las contraseñas perdidas no pueden ser recuperadas por el desarrollador. Sus datos están cifrados localmente con esta contraseña.",  // es
           "丢失的密码无法由开发者恢复。您的数据使用此密码在本地加密。",  // zh
           "खोए हुए पासवर्ड डेवलपर द्वारा पुनर्प्राप्त नहीं किए जा सकते। आपका डेटा इस पासवर्ड से स्थानीय रूप से एन्क्रिप्टेड है।",  // hi
           "لا يمكن للمطور استعادة كلمات المرور المفقودة. بياناتك مشفرة محليًا باستخدام هذه الكلمة.",  // ar
           "Senhas perdidas não podem ser recuperadas pelo desenvolvedor. Seus dados são criptografados localmente com esta senha.",  // pt
           "হারানো পাসওয়ার্ড পুনরুদ্ধার করা যাবে না। আপনার ডেটা এই পাসওয়ার্ড দিয়ে এনক্রিপ্ট করা।",  // bn
           "Утерянные пароли не могут быть восстановлены разработчиком. Данные зашифрованы локально этим паролем.",  // ru
           "紛失したパスワードは開発者でも復元できません。このパスワードでデータはローカルに暗号化されています。",  // jp
           "ਖੋਏ ਪਾਸਵਰਡ ਮੁੜ ਪ੍ਰਾਪਤ ਨਹੀਂ ਹੋ ਸਕਦੇ। ਤੁਹਾਡਾ ਡਾਟਾ ਇਸ ਨਾਲ ਐਨਕ੍ਰਿਪਟ ਹੈ।",  // pa
           "Verlorene Passwörter können nicht wiederhergestellt werden. Ihre Daten sind lokal verschlüsselt.",  // de
           "Sandhi ilang ora bisa dibalekake. Data dienkripsi lokal.",  // jv
           "잃어버린 비밀번호는 복구할 수 없습니다. 데이터는 로컬에서 암호화됩니다.",  // ko
           "Les mots de passe perdus ne peuvent pas être récupérés. Vos données sont chiffrées localement.",  // fr
           "పాస్‌వర్డ్ పోతే తిరిగి పొందలేరు. డేటా లోకల్‌గా ఎన్క్రిప్ట్ చేయబడింది.",  // te
           "हरवलेले पासवर्ड परत मिळत नाहीत. डेटा स्थानिक एन्क्रिप्ट.",  // mr
           "Kayıp şifreler geri alınamaz. Veriler yerel olarak şifrelenir.",  // tr
           "கடவுச்சொல் இழந்தால் மீட்க முடியாது. தரவு உள்ளகமாக குறியாக்கம் செய்யப்பட்டுள்ளது.",  // ta
           "Mật khẩu bị mất không thể khôi phục. Dữ liệu được mã hóa cục bộ.",  // vi
           "کھویا پاس ورڈ واپس نہیں ملے گا۔ ڈیٹا لوکل انکرپٹڈ ہے۔",  // ur
           "Le password perse non possono essere recuperate. I dati sono criptati localmente.",  // it
           "รหัสผ่านที่หายไปไม่สามารถกู้คืนได้ ข้อมูลถูกเข้ารหัสในเครื่อง",  // th
           "ખોવાયેલ પાસવર્ડ પુનઃપ્રાપ્ત કરી શકાતો નથી. ડેટા લોકલ એન્ક્રિપ્ટ છે.",  // gu
           "Utraconych haseł nie można odzyskać. Dane są lokalnie szyfrowane.",  // pl
           "Втрачені паролі не можна відновити. Дані зашифровані локально.",  // uk
           "رمز عبور از دست رفته قابل بازیابی نیست. داده‌ها به‌صورت محلی رمزگذاری شده‌اند.",  // fa
           "Kata laluan hilang tidak boleh dipulihkan. Data disulitkan secara tempatan.",  // ms
           "Parolele pierdute nu pot fi recuperate. Datele sunt criptate local.",  // ro
           "Verloren wachtwoorden kunnen niet worden hersteld. Gegevens zijn lokaal versleuteld."  // nl
        );

        public static LanguageText username = new LanguageText(
           "Username", "Όνομα χρήστη", "Nombre de usuario", "用户名", "उपयोगकर्ता नाम", "اسم المستخدم", "Nome de usuário", "ব্যবহারকারীর নাম", "Имя пользователя", "ユーザー名", "ਯੂਜ਼ਰਨਾਮ", "Benutzername", "Jeneng pangguna", "사용자 이름", "Nom d'utilisateur", "యూజర్‌నేమ్", "वापरकर्ता नाव", "Kullanıcı adı", "பயனர் பெயர்", "Tên người dùng", "صارف نام", "Nome utente", "ชื่อผู้ใช้", "યુઝરનેમ", "Nazwa użytkownika", "Ім’я користувача", "نام کاربری", "Nama pengguna", "Nume utilizator", "Gebruikersnaam"
        );

        public static LanguageText password = new LanguageText(
           "Password", "Κωδικός", "Contraseña", "密码", "पासवर्ड", "كلمة المرور", "Senha", "পাসওয়ার্ড", "Пароль", "パスワード", "ਪਾਸਵਰਡ", "Passwort", "Sandhi", "비밀번호", "Mot de passe", "పాస్‌వర్డ్", "पासवर्ड", "Şifre", "கடவுச்சொல்", "Mật khẩu", "پاس ورڈ", "Password", "รหัสผ่าน", "પાસવર્ડ", "Hasło", "Пароль", "رمز عبور", "Kata laluan", "Parolă", "Wachtwoord"
        );

        public static LanguageText exitApplication = new LanguageText(
           "Exit Application",  // en
           "Έξοδος από την εφαρμογή",  // el
           "Salir de la aplicación",  // es
           "退出应用程序",  // zh
           "एप्लिकेशन से बाहर निकलें",  // hi
           "الخروج من التطبيق",  // ar
           "Sair do aplicativo",  // pt
           "অ্যাপ্লিকেশন থেকে বের হন",  // bn
           "Выйти из приложения",  // ru
           "アプリを終了",  // jp
           "ਐਪ ਤੋਂ ਬਾਹਰ ਨਿਕਲੋ",  // pa
           "Anwendung beenden",  // de
           "Metu aplikasi",  // jv
           "앱 종료",  // ko
           "Quitter l'application",  // fr
           "యాప్ నుంచి బయటకు రండి",  // te
           "अ‍ॅप बंद करा",  // mr
           "Uygulamadan çık",  // tr
           "பயன்பாட்டை விட்டு வெளியேறு",  // ta
           "Thoát ứng dụng",  // vi
           "ایپلیکیشن سے باہر نکلیں",  // ur
           "Esci dall'applicazione",  // it
           "ออกจากแอปพลิเคชัน",  // th
           "એપ્લિકેશનમાંથી બહાર નીકળો",  // gu
           "Zamknij aplikację",  // pl
           "Вийти з програми",  // uk
           "خروج از برنامه",  // fa
           "Keluar aplikasi",  // ms
           "Ieși din aplicație",  // ro
           "Applicatie afsluiten"  // nl
        );

        public static string GetDayLanguageText(DateTime date)
        {
            return date.DayOfWeek switch
            {
                DayOfWeek.Monday => monday.GetText(selectedlanguadge) + " " + date.ToString("dd"),
                DayOfWeek.Tuesday => tuesday.GetText(selectedlanguadge) + " " + date.ToString("dd"),
                DayOfWeek.Wednesday => wednesday.GetText(selectedlanguadge) + " " + date.ToString("dd"),
                DayOfWeek.Thursday => thursday.GetText(selectedlanguadge) + " " + date.ToString("dd"),
                DayOfWeek.Friday => friday.GetText(selectedlanguadge) + " " + date.ToString("dd"),
                DayOfWeek.Saturday => saturday.GetText(selectedlanguadge) + " " + date.ToString("dd"),
                DayOfWeek.Sunday => sunday.GetText(selectedlanguadge) + " " + date.ToString("dd"),
                _ => monday.GetText(selectedlanguadge) + " " + date.ToString("dd")
            };
        }
        public static string GetMonthLanguageText(DateTime date)
        {
            return date.Month switch
            {
                1 => date.ToString("dd ") + january.GetText(selectedlanguadge) + date.ToString(" yyyy"),
                2 => date.ToString("dd ") + february.GetText(selectedlanguadge) + date.ToString(" yyyy"),
                3 => date.ToString("dd ") + march.GetText(selectedlanguadge) + date.ToString(" yyyy"),
                4 => date.ToString("dd ") + april.GetText(selectedlanguadge) + date.ToString(" yyyy"),
                5 => date.ToString("dd ") + may.GetText(selectedlanguadge) + date.ToString(" yyyy"),
                6 => date.ToString("dd ") + june.GetText(selectedlanguadge) + date.ToString(" yyyy"),
                7 => date.ToString("dd ") + july.GetText(selectedlanguadge) + date.ToString(" yyyy"),
                8 => date.ToString("dd ") + august.GetText(selectedlanguadge) + date.ToString(" yyyy"),
                9 => date.ToString("dd ") + september.GetText(selectedlanguadge) + date.ToString(" yyyy"),
                10 => date.ToString("dd ") + october.GetText(selectedlanguadge) + date.ToString(" yyyy"),
                11 => date.ToString("dd ") + november.GetText(selectedlanguadge) + date.ToString(" yyyy"),
                12 => date.ToString("dd ") + december.GetText(selectedlanguadge) + date.ToString(" yyyy"),
                _ => date.ToString("dd ") + january.GetText(selectedlanguadge) + date.ToString(" yyyy")  // Fallback
            };
        }




    }

    public class DateToLanguageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime date)
            {
                // Here we call your existing static function!
                return LanguadgeReady.GetMonthLanguageText(date);
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class LanguageText
    {
        public string English { get; set; }
        public string Greek { get; set; }
        public string Spanish { get; set; }
        public string ChineseSimplified { get; set; }
        public string Hindi { get; set; }
        public string Arabic { get; set; }
        public string Portuguese { get; set; }
        public string Bengali { get; set; }
        public string Russian { get; set; }
        public string Japanese { get; set; }
        public string Punjabi { get; set; }
        public string German { get; set; }
        public string Javanese { get; set; }
        public string Korean { get; set; }
        public string French { get; set; }
        public string Telugu { get; set; }
        public string Marathi { get; set; }
        public string Turkish { get; set; }
        public string Tamil { get; set; }
        public string Vietnamese { get; set; }
        public string Urdu { get; set; }
        public string Italian { get; set; }
        public string Thai { get; set; }
        public string Gujarati { get; set; }
        public string Polish { get; set; }
        public string Ukrainian { get; set; }
        public string Persian { get; set; }
        public string Malay { get; set; }
        public string Romanian { get; set; }
        public string Dutch { get; set; }

        public LanguageText(
            string en, string el, string es, string zh, string hi, string ar,
            string pt, string bn, string ru, string jp, string pa, string de,
            string jv, string ko, string fr, string te, string mr, string tr,
            string ta, string vi, string ur, string it, string th, string gu,
            string pl, string uk, string fa, string ms, string ro, string nl)
        {
            English = en;
            Greek = el;
            Spanish = es;
            ChineseSimplified = zh;
            Hindi = hi;
            Arabic = ar;
            Portuguese = pt;
            Bengali = bn;
            Russian = ru;
            Japanese = jp;
            Punjabi = pa;
            German = de;
            Javanese = jv;
            Korean = ko;
            French = fr;
            Telugu = te;
            Marathi = mr;
            Turkish = tr;
            Tamil = ta;
            Vietnamese = vi;
            Urdu = ur;
            Italian = it;
            Thai = th;
            Gujarati = gu;
            Polish = pl;
            Ukrainian = uk;
            Persian = fa;
            Malay = ms;
            Romanian = ro;
            Dutch = nl;
        }

        public string GetText(string langCode)
        {
            return langCode.ToLower() switch
            {
                "el" => Greek,
                "es" => Spanish,
                "zh" => ChineseSimplified,
                "hi" => Hindi,
                "ar" => Arabic,
                "pt" => Portuguese,
                "bn" => Bengali,
                "ru" => Russian,
                "jp" => Japanese,
                "pa" => Punjabi,
                "de" => German,
                "jv" => Javanese,
                "ko" => Korean,
                "fr" => French,
                "te" => Telugu,
                "mr" => Marathi,
                "tr" => Turkish,
                "ta" => Tamil,
                "vi" => Vietnamese,
                "ur" => Urdu,
                "it" => Italian,
                "th" => Thai,
                "gu" => Gujarati,
                "pl" => Polish,
                "uk" => Ukrainian,
                "fa" => Persian,
                "ms" => Malay,
                "ro" => Romanian,
                "nl" => Dutch,
                _ => English
            };
        }
    }
}
