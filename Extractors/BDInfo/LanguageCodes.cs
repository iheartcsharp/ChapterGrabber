﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BDInfo
{
    public abstract class LanguageCodes
    {
        public static List<KeyValuePair<string, string>> GetTopLanguages()
        {
            return GetLanguages().Where(l =>
              l.Key == "chi" ||
              l.Key == "dut" ||
              l.Key == "eng" ||
              l.Key == "fin" ||
              l.Key == "fre" ||
              l.Key == "ger" ||
              l.Key == "ita" ||
              l.Key == "jpn" ||
              l.Key == "nor" ||
              l.Key == "por" ||
              l.Key == "ita" ||
              l.Key == "rus" ||
              l.Key == "spa" ||
              l.Key == "swe").ToList();
        }

        public static List<KeyValuePair<string, string>> GetLanguages()
        {
            //did not use dictionary in case of duplicates
            List<KeyValuePair<string, string>> langs = new List<KeyValuePair<string, string>>();
            langs.Add(new KeyValuePair<string, string>("abk", "Abkhazian"));
            langs.Add(new KeyValuePair<string, string>("ace", "Achinese"));
            langs.Add(new KeyValuePair<string, string>("ach", "Acoli"));
            langs.Add(new KeyValuePair<string, string>("ada", "Adangme"));
            langs.Add(new KeyValuePair<string, string>("aar", "Afar"));
            langs.Add(new KeyValuePair<string, string>("afh", "Afrihili"));
            langs.Add(new KeyValuePair<string, string>("afr", "Afrikaans"));
            langs.Add(new KeyValuePair<string, string>("afa", "Afro-Asiatic (Other)"));
            langs.Add(new KeyValuePair<string, string>("aka", "Akan"));
            langs.Add(new KeyValuePair<string, string>("akk", "Akkadian"));
            langs.Add(new KeyValuePair<string, string>("alb", "Albanian"));
            langs.Add(new KeyValuePair<string, string>("sqi", "Albanian"));
            langs.Add(new KeyValuePair<string, string>("ale", "Aleut"));
            langs.Add(new KeyValuePair<string, string>("alg", "Algonquian languages"));
            langs.Add(new KeyValuePair<string, string>("tut", "Altaic (Other)"));
            langs.Add(new KeyValuePair<string, string>("amh", "Amharic"));
            langs.Add(new KeyValuePair<string, string>("apa", "Apache languages"));
            langs.Add(new KeyValuePair<string, string>("ara", "Arabic"));
            langs.Add(new KeyValuePair<string, string>("arc", "Aramaic"));
            langs.Add(new KeyValuePair<string, string>("arp", "Arapaho"));
            langs.Add(new KeyValuePair<string, string>("arn", "Araucanian"));
            langs.Add(new KeyValuePair<string, string>("arw", "Arawak"));
            langs.Add(new KeyValuePair<string, string>("arm", "Armenian"));
            langs.Add(new KeyValuePair<string, string>("hye", "Armenian"));
            langs.Add(new KeyValuePair<string, string>("art", "Artificial (Other)"));
            langs.Add(new KeyValuePair<string, string>("asm", "Assamese"));
            langs.Add(new KeyValuePair<string, string>("ath", "Athapascan languages"));
            langs.Add(new KeyValuePair<string, string>("aus", "Australian languages"));
            langs.Add(new KeyValuePair<string, string>("map", "Austronesian (Other)"));
            langs.Add(new KeyValuePair<string, string>("ava", "Avaric"));
            langs.Add(new KeyValuePair<string, string>("ave", "Avestan"));
            langs.Add(new KeyValuePair<string, string>("awa", "Awadhi"));
            langs.Add(new KeyValuePair<string, string>("aym", "Aymara"));
            langs.Add(new KeyValuePair<string, string>("aze", "Azerbaijani"));
            langs.Add(new KeyValuePair<string, string>("ban", "Balinese"));
            langs.Add(new KeyValuePair<string, string>("bat", "Baltic (Other)"));
            langs.Add(new KeyValuePair<string, string>("bal", "Baluchi"));
            langs.Add(new KeyValuePair<string, string>("bam", "Bambara"));
            langs.Add(new KeyValuePair<string, string>("bai", "Bamileke languages"));
            langs.Add(new KeyValuePair<string, string>("bad", "Banda"));
            langs.Add(new KeyValuePair<string, string>("bnt", "Bantu (Other)"));
            langs.Add(new KeyValuePair<string, string>("bas", "Basa"));
            langs.Add(new KeyValuePair<string, string>("bak", "Bashkir"));
            langs.Add(new KeyValuePair<string, string>("baq", "Basque"));
            langs.Add(new KeyValuePair<string, string>("eus", "Basque"));
            langs.Add(new KeyValuePair<string, string>("btk", "Batak (Indonesia)"));
            langs.Add(new KeyValuePair<string, string>("bej", "Beja"));
            langs.Add(new KeyValuePair<string, string>("bel", "Belarusian"));
            langs.Add(new KeyValuePair<string, string>("bem", "Bemba"));
            langs.Add(new KeyValuePair<string, string>("ben", "Bengali"));
            langs.Add(new KeyValuePair<string, string>("ber", "Berber (Other)"));
            langs.Add(new KeyValuePair<string, string>("bho", "Bhojpuri"));
            langs.Add(new KeyValuePair<string, string>("bih", "Bihari"));
            langs.Add(new KeyValuePair<string, string>("bik", "Bikol"));
            langs.Add(new KeyValuePair<string, string>("bin", "Bini"));
            langs.Add(new KeyValuePair<string, string>("bis", "Bislama"));
            langs.Add(new KeyValuePair<string, string>("bos", "Bosnian"));
            langs.Add(new KeyValuePair<string, string>("bra", "Braj"));
            langs.Add(new KeyValuePair<string, string>("bre", "Breton"));
            langs.Add(new KeyValuePair<string, string>("bug", "Buginese"));
            langs.Add(new KeyValuePair<string, string>("bul", "Bulgarian"));
            langs.Add(new KeyValuePair<string, string>("bua", "Buriat"));
            langs.Add(new KeyValuePair<string, string>("bur", "Burmese"));
            langs.Add(new KeyValuePair<string, string>("mya", "Burmese"));
            langs.Add(new KeyValuePair<string, string>("cad", "Caddo"));
            langs.Add(new KeyValuePair<string, string>("car", "Carib"));
            langs.Add(new KeyValuePair<string, string>("cat", "Catalan"));
            langs.Add(new KeyValuePair<string, string>("cau", "Caucasian (Other)"));
            langs.Add(new KeyValuePair<string, string>("ceb", "Cebuano"));
            langs.Add(new KeyValuePair<string, string>("cel", "Celtic (Other)"));
            langs.Add(new KeyValuePair<string, string>("cai", "Central American Indian (Other)"));
            langs.Add(new KeyValuePair<string, string>("chg", "Chagatai"));
            langs.Add(new KeyValuePair<string, string>("cmc", "Chamic languages"));
            langs.Add(new KeyValuePair<string, string>("cha", "Chamorro"));
            langs.Add(new KeyValuePair<string, string>("che", "Chechen"));
            langs.Add(new KeyValuePair<string, string>("chr", "Cherokee"));
            langs.Add(new KeyValuePair<string, string>("chy", "Cheyenne"));
            langs.Add(new KeyValuePair<string, string>("chb", "Chibcha"));
            langs.Add(new KeyValuePair<string, string>("chi", "Chinese"));
            langs.Add(new KeyValuePair<string, string>("zho", "Chinese"));
            langs.Add(new KeyValuePair<string, string>("chn", "Chinook jargon"));
            langs.Add(new KeyValuePair<string, string>("chp", "Chipewyan"));
            langs.Add(new KeyValuePair<string, string>("cho", "Choctaw"));
            langs.Add(new KeyValuePair<string, string>("chu", "Church Slavic"));
            langs.Add(new KeyValuePair<string, string>("chk", "Chuukese"));
            langs.Add(new KeyValuePair<string, string>("chv", "Chuvash"));
            langs.Add(new KeyValuePair<string, string>("cop", "Coptic"));
            langs.Add(new KeyValuePair<string, string>("cor", "Cornish"));
            langs.Add(new KeyValuePair<string, string>("cos", "Corsican"));
            langs.Add(new KeyValuePair<string, string>("cre", "Cree"));
            langs.Add(new KeyValuePair<string, string>("mus", "Creek"));
            langs.Add(new KeyValuePair<string, string>("crp", "Creoles and pidgins (Other)"));
            langs.Add(new KeyValuePair<string, string>("cpe", "Creoles and pidgins,"));
            langs.Add(new KeyValuePair<string, string>("cpf", "Creoles and pidgins,"));
            langs.Add(new KeyValuePair<string, string>("cpp", "Creoles and pidgins,"));
            langs.Add(new KeyValuePair<string, string>("scr", "Croatian"));
            langs.Add(new KeyValuePair<string, string>("hrv", "Croatian"));
            langs.Add(new KeyValuePair<string, string>("cus", "Cushitic (Other)"));
            langs.Add(new KeyValuePair<string, string>("cze", "Czech"));
            langs.Add(new KeyValuePair<string, string>("ces", "Czech"));
            langs.Add(new KeyValuePair<string, string>("dak", "Dakota"));
            langs.Add(new KeyValuePair<string, string>("dan", "Danish"));
            langs.Add(new KeyValuePair<string, string>("day", "Dayak"));
            langs.Add(new KeyValuePair<string, string>("del", "Delaware"));
            langs.Add(new KeyValuePair<string, string>("din", "Dinka"));
            langs.Add(new KeyValuePair<string, string>("div", "Divehi"));
            langs.Add(new KeyValuePair<string, string>("doi", "Dogri"));
            langs.Add(new KeyValuePair<string, string>("dgr", "Dogrib"));
            langs.Add(new KeyValuePair<string, string>("dra", "Dravidian (Other)"));
            langs.Add(new KeyValuePair<string, string>("dua", "Duala"));
            langs.Add(new KeyValuePair<string, string>("dut", "Dutch"));
            langs.Add(new KeyValuePair<string, string>("nld", "Dutch"));
            langs.Add(new KeyValuePair<string, string>("dum", "Dutch, Middle (ca. 1050-1350)"));
            langs.Add(new KeyValuePair<string, string>("dyu", "Dyula"));
            langs.Add(new KeyValuePair<string, string>("dzo", "Dzongkha"));
            langs.Add(new KeyValuePair<string, string>("efi", "Efik"));
            langs.Add(new KeyValuePair<string, string>("egy", "Egyptian (Ancient)"));
            langs.Add(new KeyValuePair<string, string>("eka", "Ekajuk"));
            langs.Add(new KeyValuePair<string, string>("elx", "Elamite"));
            langs.Add(new KeyValuePair<string, string>("eng", "English"));
            langs.Add(new KeyValuePair<string, string>("enm", "English, Middle (1100-1500)"));
            langs.Add(new KeyValuePair<string, string>("ang", "English, Old (ca.450-1100)"));
            langs.Add(new KeyValuePair<string, string>("epo", "Esperanto"));
            langs.Add(new KeyValuePair<string, string>("est", "Estonian"));
            langs.Add(new KeyValuePair<string, string>("ewe", "Ewe"));
            langs.Add(new KeyValuePair<string, string>("ewo", "Ewondo"));
            langs.Add(new KeyValuePair<string, string>("fan", "Fang"));
            langs.Add(new KeyValuePair<string, string>("fat", "Fanti"));
            langs.Add(new KeyValuePair<string, string>("fao", "Faroese"));
            langs.Add(new KeyValuePair<string, string>("fij", "Fijian"));
            langs.Add(new KeyValuePair<string, string>("fin", "Finnish"));
            langs.Add(new KeyValuePair<string, string>("fiu", "Finno-Ugrian (Other)"));
            langs.Add(new KeyValuePair<string, string>("fon", "Fon"));
            langs.Add(new KeyValuePair<string, string>("fre", "French"));
            langs.Add(new KeyValuePair<string, string>("fra", "French"));
            langs.Add(new KeyValuePair<string, string>("frm", "French, Middle (ca.1400-1600)"));
            langs.Add(new KeyValuePair<string, string>("fro", "French, Old (842-ca.1400)"));
            langs.Add(new KeyValuePair<string, string>("fry", "Frisian"));
            langs.Add(new KeyValuePair<string, string>("fur", "Friulian"));
            langs.Add(new KeyValuePair<string, string>("ful", "Fulah"));
            langs.Add(new KeyValuePair<string, string>("gaa", "Ga"));
            langs.Add(new KeyValuePair<string, string>("glg", "Gallegan"));
            langs.Add(new KeyValuePair<string, string>("lug", "Ganda"));
            langs.Add(new KeyValuePair<string, string>("gay", "Gayo"));
            langs.Add(new KeyValuePair<string, string>("gba", "Gbaya"));
            langs.Add(new KeyValuePair<string, string>("gez", "Geez"));
            langs.Add(new KeyValuePair<string, string>("geo", "Georgian"));
            langs.Add(new KeyValuePair<string, string>("kat", "Georgian"));
            langs.Add(new KeyValuePair<string, string>("ger", "German"));
            langs.Add(new KeyValuePair<string, string>("deu", "German"));
            langs.Add(new KeyValuePair<string, string>("nds", "Saxon"));
            langs.Add(new KeyValuePair<string, string>("gmh", "German, Middle High (ca.1050-1500)"));
            langs.Add(new KeyValuePair<string, string>("goh", "German, Old High (ca.750-1050)"));
            langs.Add(new KeyValuePair<string, string>("gem", "Germanic (Other)"));
            langs.Add(new KeyValuePair<string, string>("gil", "Gilbertese"));
            langs.Add(new KeyValuePair<string, string>("gon", "Gondi"));
            langs.Add(new KeyValuePair<string, string>("gor", "Gorontalo"));
            langs.Add(new KeyValuePair<string, string>("got", "Gothic"));
            langs.Add(new KeyValuePair<string, string>("grb", "Grebo"));
            langs.Add(new KeyValuePair<string, string>("grc", "Greek, Ancient (to 1453)"));
            langs.Add(new KeyValuePair<string, string>("gre", "Greek"));
            langs.Add(new KeyValuePair<string, string>("ell", "Greek"));
            langs.Add(new KeyValuePair<string, string>("grn", "Guarani"));
            langs.Add(new KeyValuePair<string, string>("guj", "Gujarati"));
            langs.Add(new KeyValuePair<string, string>("gwi", "Gwich´in"));
            langs.Add(new KeyValuePair<string, string>("hai", "Haida"));
            langs.Add(new KeyValuePair<string, string>("hau", "Hausa"));
            langs.Add(new KeyValuePair<string, string>("haw", "Hawaiian"));
            langs.Add(new KeyValuePair<string, string>("heb", "Hebrew"));
            langs.Add(new KeyValuePair<string, string>("her", "Herero"));
            langs.Add(new KeyValuePair<string, string>("hil", "Hiligaynon"));
            langs.Add(new KeyValuePair<string, string>("him", "Himachali"));
            langs.Add(new KeyValuePair<string, string>("hin", "Hindi"));
            langs.Add(new KeyValuePair<string, string>("hmo", "Hiri Motu"));
            langs.Add(new KeyValuePair<string, string>("hit", "Hittite"));
            langs.Add(new KeyValuePair<string, string>("hmn", "Hmong"));
            langs.Add(new KeyValuePair<string, string>("hun", "Hungarian"));
            langs.Add(new KeyValuePair<string, string>("hup", "Hupa"));
            langs.Add(new KeyValuePair<string, string>("iba", "Iban"));
            langs.Add(new KeyValuePair<string, string>("ice", "Icelandic"));
            langs.Add(new KeyValuePair<string, string>("isl", "Icelandic"));
            langs.Add(new KeyValuePair<string, string>("ibo", "Igbo"));
            langs.Add(new KeyValuePair<string, string>("ijo", "Ijo"));
            langs.Add(new KeyValuePair<string, string>("ilo", "Iloko"));
            langs.Add(new KeyValuePair<string, string>("inc", "Indic (Other)"));
            langs.Add(new KeyValuePair<string, string>("ine", "Indo-European (Other)"));
            langs.Add(new KeyValuePair<string, string>("ind", "Indonesian"));
            langs.Add(new KeyValuePair<string, string>("ina", "Interlingua (International"));
            langs.Add(new KeyValuePair<string, string>("ile", "Interlingue"));
            langs.Add(new KeyValuePair<string, string>("iku", "Inuktitut"));
            langs.Add(new KeyValuePair<string, string>("ipk", "Inupiaq"));
            langs.Add(new KeyValuePair<string, string>("ira", "Iranian (Other)"));
            langs.Add(new KeyValuePair<string, string>("gle", "Irish"));
            langs.Add(new KeyValuePair<string, string>("mga", "Irish, Middle (900-1200)"));
            langs.Add(new KeyValuePair<string, string>("sga", "Irish, Old (to 900)"));
            langs.Add(new KeyValuePair<string, string>("iro", "Iroquoian languages"));
            langs.Add(new KeyValuePair<string, string>("ita", "Italian"));
            langs.Add(new KeyValuePair<string, string>("jpn", "Japanese"));
            langs.Add(new KeyValuePair<string, string>("jav", "Javanese"));
            langs.Add(new KeyValuePair<string, string>("jrb", "Judeo-Arabic"));
            langs.Add(new KeyValuePair<string, string>("jpr", "Judeo-Persian"));
            langs.Add(new KeyValuePair<string, string>("kab", "Kabyle"));
            langs.Add(new KeyValuePair<string, string>("kac", "Kachin"));
            langs.Add(new KeyValuePair<string, string>("kal", "Kalaallisut"));
            langs.Add(new KeyValuePair<string, string>("kam", "Kamba"));
            langs.Add(new KeyValuePair<string, string>("kan", "Kannada"));
            langs.Add(new KeyValuePair<string, string>("kau", "Kanuri"));
            langs.Add(new KeyValuePair<string, string>("kaa", "Kara-Kalpak"));
            langs.Add(new KeyValuePair<string, string>("kar", "Karen"));
            langs.Add(new KeyValuePair<string, string>("kas", "Kashmiri"));
            langs.Add(new KeyValuePair<string, string>("kaw", "Kawi"));
            langs.Add(new KeyValuePair<string, string>("kaz", "Kazakh"));
            langs.Add(new KeyValuePair<string, string>("kha", "Khasi"));
            langs.Add(new KeyValuePair<string, string>("khm", "Khmer"));
            langs.Add(new KeyValuePair<string, string>("khi", "Khoisan (Other)"));
            langs.Add(new KeyValuePair<string, string>("kho", "Khotanese"));
            langs.Add(new KeyValuePair<string, string>("kik", "Kikuyu"));
            langs.Add(new KeyValuePair<string, string>("kmb", "Kimbundu"));
            langs.Add(new KeyValuePair<string, string>("kin", "Kinyarwanda"));
            langs.Add(new KeyValuePair<string, string>("kir", "Kirghiz"));
            langs.Add(new KeyValuePair<string, string>("kom", "Komi"));
            langs.Add(new KeyValuePair<string, string>("kon", "Kongo"));
            langs.Add(new KeyValuePair<string, string>("kok", "Konkani"));
            langs.Add(new KeyValuePair<string, string>("kor", "Korean"));
            langs.Add(new KeyValuePair<string, string>("kos", "Kosraean"));
            langs.Add(new KeyValuePair<string, string>("kpe", "Kpelle"));
            langs.Add(new KeyValuePair<string, string>("kro", "Kru"));
            langs.Add(new KeyValuePair<string, string>("kua", "Kuanyama"));
            langs.Add(new KeyValuePair<string, string>("kum", "Kumyk"));
            langs.Add(new KeyValuePair<string, string>("kur", "Kurdish"));
            langs.Add(new KeyValuePair<string, string>("kru", "Kurukh"));
            langs.Add(new KeyValuePair<string, string>("kut", "Kutenai"));
            langs.Add(new KeyValuePair<string, string>("lad", "Ladino"));
            langs.Add(new KeyValuePair<string, string>("lah", "Lahnda"));
            langs.Add(new KeyValuePair<string, string>("lam", "Lamba"));
            langs.Add(new KeyValuePair<string, string>("lao", "Lao"));
            langs.Add(new KeyValuePair<string, string>("lat", "Latin"));
            langs.Add(new KeyValuePair<string, string>("lav", "Latvian"));
            langs.Add(new KeyValuePair<string, string>("ltz", "Letzeburgesch"));
            langs.Add(new KeyValuePair<string, string>("lez", "Lezghian"));
            langs.Add(new KeyValuePair<string, string>("lin", "Lingala"));
            langs.Add(new KeyValuePair<string, string>("lit", "Lithuanian"));
            langs.Add(new KeyValuePair<string, string>("loz", "Lozi"));
            langs.Add(new KeyValuePair<string, string>("lub", "Luba-Katanga"));
            langs.Add(new KeyValuePair<string, string>("lua", "Luba-Lulua"));
            langs.Add(new KeyValuePair<string, string>("lui", "Luiseno"));
            langs.Add(new KeyValuePair<string, string>("lun", "Lunda"));
            langs.Add(new KeyValuePair<string, string>("luo", "Luo (Kenya and Tanzania)"));
            langs.Add(new KeyValuePair<string, string>("lus", "Lushai"));
            langs.Add(new KeyValuePair<string, string>("mac", "Macedonian"));
            langs.Add(new KeyValuePair<string, string>("mkd", "Macedonian"));
            langs.Add(new KeyValuePair<string, string>("mad", "Madurese"));
            langs.Add(new KeyValuePair<string, string>("mag", "Magahi"));
            langs.Add(new KeyValuePair<string, string>("mai", "Maithili"));
            langs.Add(new KeyValuePair<string, string>("mak", "Makasar"));
            langs.Add(new KeyValuePair<string, string>("mlg", "Malagasy"));
            langs.Add(new KeyValuePair<string, string>("may", "Malay"));
            langs.Add(new KeyValuePair<string, string>("msa", "Malay"));
            langs.Add(new KeyValuePair<string, string>("mal", "Malayalam"));
            langs.Add(new KeyValuePair<string, string>("mlt", "Maltese"));
            langs.Add(new KeyValuePair<string, string>("mnc", "Manchu"));
            langs.Add(new KeyValuePair<string, string>("mdr", "Mandar"));
            langs.Add(new KeyValuePair<string, string>("man", "Mandingo"));
            langs.Add(new KeyValuePair<string, string>("mni", "Manipuri"));
            langs.Add(new KeyValuePair<string, string>("mno", "Manobo languages"));
            langs.Add(new KeyValuePair<string, string>("glv", "Manx"));
            langs.Add(new KeyValuePair<string, string>("mao", "Maori"));
            langs.Add(new KeyValuePair<string, string>("mri", "Maori"));
            langs.Add(new KeyValuePair<string, string>("mar", "Marathi"));
            langs.Add(new KeyValuePair<string, string>("chm", "Mari"));
            langs.Add(new KeyValuePair<string, string>("mah", "Marshall"));
            langs.Add(new KeyValuePair<string, string>("mwr", "Marwari"));
            langs.Add(new KeyValuePair<string, string>("mas", "Masai"));
            langs.Add(new KeyValuePair<string, string>("myn", "Mayan languages"));
            langs.Add(new KeyValuePair<string, string>("men", "Mende"));
            langs.Add(new KeyValuePair<string, string>("mic", "Micmac"));
            langs.Add(new KeyValuePair<string, string>("min", "Minangkabau"));
            langs.Add(new KeyValuePair<string, string>("mis", "Miscellaneous languages"));
            langs.Add(new KeyValuePair<string, string>("moh", "Mohawk"));
            langs.Add(new KeyValuePair<string, string>("mol", "Moldavian"));
            langs.Add(new KeyValuePair<string, string>("mkh", "Mon-Khmer (Other)"));
            langs.Add(new KeyValuePair<string, string>("lol", "Mongo"));
            langs.Add(new KeyValuePair<string, string>("mon", "Mongolian"));
            langs.Add(new KeyValuePair<string, string>("mos", "Mossi"));
            langs.Add(new KeyValuePair<string, string>("mul", "Multiple languages"));
            langs.Add(new KeyValuePair<string, string>("mun", "Munda languages"));
            langs.Add(new KeyValuePair<string, string>("nah", "Nahuatl"));
            langs.Add(new KeyValuePair<string, string>("nau", "Nauru"));
            langs.Add(new KeyValuePair<string, string>("nav", "Navajo"));
            langs.Add(new KeyValuePair<string, string>("nde", "Ndebele, North"));
            langs.Add(new KeyValuePair<string, string>("nbl", "Ndebele, South"));
            langs.Add(new KeyValuePair<string, string>("ndo", "Ndonga"));
            langs.Add(new KeyValuePair<string, string>("nep", "Nepali"));
            langs.Add(new KeyValuePair<string, string>("new", "Newari"));
            langs.Add(new KeyValuePair<string, string>("nia", "Nias"));
            langs.Add(new KeyValuePair<string, string>("nic", "Niger-Kordofanian (Other)"));
            langs.Add(new KeyValuePair<string, string>("ssa", "Nilo-Saharan (Other)"));
            langs.Add(new KeyValuePair<string, string>("niu", "Niuean"));
            langs.Add(new KeyValuePair<string, string>("non", "Norse, Old"));
            langs.Add(new KeyValuePair<string, string>("nai", "North American Indian (Other)"));
            langs.Add(new KeyValuePair<string, string>("sme", "Northern Sami"));
            langs.Add(new KeyValuePair<string, string>("nor", "Norwegian"));
            langs.Add(new KeyValuePair<string, string>("nob", "Norwegian Bokmål"));
            langs.Add(new KeyValuePair<string, string>("nno", "Norwegian Nynorsk"));
            langs.Add(new KeyValuePair<string, string>("nub", "Nubian languages"));
            langs.Add(new KeyValuePair<string, string>("nym", "Nyamwezi"));
            langs.Add(new KeyValuePair<string, string>("nya", "Nyanja"));
            langs.Add(new KeyValuePair<string, string>("nyn", "Nyankole"));
            langs.Add(new KeyValuePair<string, string>("nyo", "Nyoro"));
            langs.Add(new KeyValuePair<string, string>("nzi", "Nzima"));
            langs.Add(new KeyValuePair<string, string>("oci", "Occitan"));
            langs.Add(new KeyValuePair<string, string>("oji", "Ojibwa"));
            langs.Add(new KeyValuePair<string, string>("ori", "Oriya"));
            langs.Add(new KeyValuePair<string, string>("orm", "Oromo"));
            langs.Add(new KeyValuePair<string, string>("osa", "Osage"));
            langs.Add(new KeyValuePair<string, string>("oss", "Ossetian"));
            langs.Add(new KeyValuePair<string, string>("oto", "Otomian languages"));
            langs.Add(new KeyValuePair<string, string>("pal", "Pahlavi"));
            langs.Add(new KeyValuePair<string, string>("pau", "Palauan"));
            langs.Add(new KeyValuePair<string, string>("pli", "Pali"));
            langs.Add(new KeyValuePair<string, string>("pam", "Pampanga"));
            langs.Add(new KeyValuePair<string, string>("pag", "Pangasinan"));
            langs.Add(new KeyValuePair<string, string>("pan", "Panjabi"));
            langs.Add(new KeyValuePair<string, string>("pap", "Papiamento"));
            langs.Add(new KeyValuePair<string, string>("paa", "Papuan (Other)"));
            langs.Add(new KeyValuePair<string, string>("per", "Persian"));
            langs.Add(new KeyValuePair<string, string>("fas", "Persian"));
            langs.Add(new KeyValuePair<string, string>("peo", "Persian, Old (ca.600-400 B.C.)"));
            langs.Add(new KeyValuePair<string, string>("phi", "Philippine (Other)"));
            langs.Add(new KeyValuePair<string, string>("phn", "Phoenician"));
            langs.Add(new KeyValuePair<string, string>("pon", "Pohnpeian"));
            langs.Add(new KeyValuePair<string, string>("pol", "Polish"));
            langs.Add(new KeyValuePair<string, string>("por", "Portuguese"));
            langs.Add(new KeyValuePair<string, string>("pra", "Prakrit languages"));
            langs.Add(new KeyValuePair<string, string>("pro", "Provençal"));
            langs.Add(new KeyValuePair<string, string>("pus", "Pushto"));
            langs.Add(new KeyValuePair<string, string>("que", "Quechua"));
            langs.Add(new KeyValuePair<string, string>("roh", "Raeto-Romance"));
            langs.Add(new KeyValuePair<string, string>("raj", "Rajasthani"));
            langs.Add(new KeyValuePair<string, string>("rap", "Rapanui"));
            langs.Add(new KeyValuePair<string, string>("rar", "Rarotongan"));
            langs.Add(new KeyValuePair<string, string>("roa", "Romance (Other)"));
            langs.Add(new KeyValuePair<string, string>("rum", "Romanian"));
            langs.Add(new KeyValuePair<string, string>("ron", "Romanian"));
            langs.Add(new KeyValuePair<string, string>("rom", "Romany"));
            langs.Add(new KeyValuePair<string, string>("run", "Rundi"));
            langs.Add(new KeyValuePair<string, string>("rus", "Russian"));
            langs.Add(new KeyValuePair<string, string>("sal", "Salishan languages"));
            langs.Add(new KeyValuePair<string, string>("sam", "Samaritan Aramaic"));
            langs.Add(new KeyValuePair<string, string>("smi", "Sami languages (Other)"));
            langs.Add(new KeyValuePair<string, string>("smo", "Samoan"));
            langs.Add(new KeyValuePair<string, string>("sad", "Sandawe"));
            langs.Add(new KeyValuePair<string, string>("sag", "Sango"));
            langs.Add(new KeyValuePair<string, string>("san", "Sanskrit"));
            langs.Add(new KeyValuePair<string, string>("sat", "Santali"));
            langs.Add(new KeyValuePair<string, string>("srd", "Sardinian"));
            langs.Add(new KeyValuePair<string, string>("sas", "Sasak"));
            langs.Add(new KeyValuePair<string, string>("sco", "Scots"));
            langs.Add(new KeyValuePair<string, string>("gla", "Gaelic"));
            langs.Add(new KeyValuePair<string, string>("sel", "Selkup"));
            langs.Add(new KeyValuePair<string, string>("sem", "Semitic (Other)"));
            langs.Add(new KeyValuePair<string, string>("scc", "Serbian"));
            langs.Add(new KeyValuePair<string, string>("srp", "Serbian"));
            langs.Add(new KeyValuePair<string, string>("srr", "Serer"));
            langs.Add(new KeyValuePair<string, string>("shn", "Shan"));
            langs.Add(new KeyValuePair<string, string>("sna", "Shona"));
            langs.Add(new KeyValuePair<string, string>("sid", "Sidamo"));
            langs.Add(new KeyValuePair<string, string>("sgn", "Sign languages"));
            langs.Add(new KeyValuePair<string, string>("bla", "Siksika"));
            langs.Add(new KeyValuePair<string, string>("snd", "Sindhi"));
            langs.Add(new KeyValuePair<string, string>("sin", "Sinhalese"));
            langs.Add(new KeyValuePair<string, string>("sit", "Sino-Tibetan (Other)"));
            langs.Add(new KeyValuePair<string, string>("sio", "Siouan languages"));
            langs.Add(new KeyValuePair<string, string>("den", "Slave (Athapascan)"));
            langs.Add(new KeyValuePair<string, string>("sla", "Slavic (Other)"));
            langs.Add(new KeyValuePair<string, string>("slo", "Slovak"));
            langs.Add(new KeyValuePair<string, string>("slk", "Slovak"));
            langs.Add(new KeyValuePair<string, string>("slv", "Slovenian"));
            langs.Add(new KeyValuePair<string, string>("sog", "Sogdian"));
            langs.Add(new KeyValuePair<string, string>("som", "Somali"));
            langs.Add(new KeyValuePair<string, string>("son", "Songhai"));
            langs.Add(new KeyValuePair<string, string>("snk", "Soninke"));
            langs.Add(new KeyValuePair<string, string>("wen", "Sorbian languages"));
            langs.Add(new KeyValuePair<string, string>("nso", "Sotho, Northern"));
            langs.Add(new KeyValuePair<string, string>("sot", "Sotho, Southern"));
            langs.Add(new KeyValuePair<string, string>("sai", "South American Indian (Other)"));
            langs.Add(new KeyValuePair<string, string>("spa", "Spanish"));
            langs.Add(new KeyValuePair<string, string>("suk", "Sukuma"));
            langs.Add(new KeyValuePair<string, string>("sux", "Sumerian"));
            langs.Add(new KeyValuePair<string, string>("sun", "Sundanese"));
            langs.Add(new KeyValuePair<string, string>("sus", "Susu"));
            langs.Add(new KeyValuePair<string, string>("swa", "Swahili"));
            langs.Add(new KeyValuePair<string, string>("ssw", "Swati"));
            langs.Add(new KeyValuePair<string, string>("swe", "Swedish"));
            langs.Add(new KeyValuePair<string, string>("syr", "Syriac"));
            langs.Add(new KeyValuePair<string, string>("tgl", "Tagalog"));
            langs.Add(new KeyValuePair<string, string>("tah", "Tahitian"));
            langs.Add(new KeyValuePair<string, string>("tai", "Tai (Other)"));
            langs.Add(new KeyValuePair<string, string>("tgk", "Tajik"));
            langs.Add(new KeyValuePair<string, string>("tmh", "Tamashek"));
            langs.Add(new KeyValuePair<string, string>("tam", "Tamil"));
            langs.Add(new KeyValuePair<string, string>("tat", "Tatar"));
            langs.Add(new KeyValuePair<string, string>("tel", "Telugu"));
            langs.Add(new KeyValuePair<string, string>("ter", "Tereno"));
            langs.Add(new KeyValuePair<string, string>("tet", "Tetum"));
            langs.Add(new KeyValuePair<string, string>("tha", "Thai"));
            langs.Add(new KeyValuePair<string, string>("tib", "Tibetan"));
            langs.Add(new KeyValuePair<string, string>("bod", "Tibetan"));
            langs.Add(new KeyValuePair<string, string>("tig", "Tigre"));
            langs.Add(new KeyValuePair<string, string>("tir", "Tigrinya"));
            langs.Add(new KeyValuePair<string, string>("tem", "Timne"));
            langs.Add(new KeyValuePair<string, string>("tiv", "Tiv"));
            langs.Add(new KeyValuePair<string, string>("tli", "Tlingit"));
            langs.Add(new KeyValuePair<string, string>("tpi", "Tok Pisin"));
            langs.Add(new KeyValuePair<string, string>("tkl", "Tokelau"));
            langs.Add(new KeyValuePair<string, string>("tog", "Tonga (Nyasa)"));
            langs.Add(new KeyValuePair<string, string>("ton", "Tonga (Tonga Islands)"));
            langs.Add(new KeyValuePair<string, string>("tsi", "Tsimshian"));
            langs.Add(new KeyValuePair<string, string>("tso", "Tsonga"));
            langs.Add(new KeyValuePair<string, string>("tsn", "Tswana"));
            langs.Add(new KeyValuePair<string, string>("tum", "Tumbuka"));
            langs.Add(new KeyValuePair<string, string>("tur", "Turkish"));
            langs.Add(new KeyValuePair<string, string>("ota", "Turkish, Ottoman (1500-1928)"));
            langs.Add(new KeyValuePair<string, string>("tuk", "Turkmen"));
            langs.Add(new KeyValuePair<string, string>("tvl", "Tuvalu"));
            langs.Add(new KeyValuePair<string, string>("tyv", "Tuvinian"));
            langs.Add(new KeyValuePair<string, string>("twi", "Twi"));
            langs.Add(new KeyValuePair<string, string>("uga", "Ugaritic"));
            langs.Add(new KeyValuePair<string, string>("uig", "Uighur"));
            langs.Add(new KeyValuePair<string, string>("ukr", "Ukrainian"));
            langs.Add(new KeyValuePair<string, string>("umb", "Umbundu"));
            langs.Add(new KeyValuePair<string, string>("und", "Undetermined"));
            langs.Add(new KeyValuePair<string, string>("urd", "Urdu"));
            langs.Add(new KeyValuePair<string, string>("uzb", "Uzbek"));
            langs.Add(new KeyValuePair<string, string>("vai", "Vai"));
            langs.Add(new KeyValuePair<string, string>("ven", "Venda"));
            langs.Add(new KeyValuePair<string, string>("vie", "Vietnamese"));
            langs.Add(new KeyValuePair<string, string>("vol", "Volapük"));
            langs.Add(new KeyValuePair<string, string>("vot", "Votic"));
            langs.Add(new KeyValuePair<string, string>("wak", "Wakashan languages"));
            langs.Add(new KeyValuePair<string, string>("wal", "Walamo"));
            langs.Add(new KeyValuePair<string, string>("war", "Waray"));
            langs.Add(new KeyValuePair<string, string>("was", "Washo"));
            langs.Add(new KeyValuePair<string, string>("wel", "Welsh"));
            langs.Add(new KeyValuePair<string, string>("cym", "Welsh"));
            langs.Add(new KeyValuePair<string, string>("wol", "Wolof"));
            langs.Add(new KeyValuePair<string, string>("xho", "Xhosa"));
            langs.Add(new KeyValuePair<string, string>("sah", "Yakut"));
            langs.Add(new KeyValuePair<string, string>("yao", "Yao"));
            langs.Add(new KeyValuePair<string, string>("yap", "Yapese"));
            langs.Add(new KeyValuePair<string, string>("yid", "Yiddish"));
            langs.Add(new KeyValuePair<string, string>("yor", "Yoruba"));
            langs.Add(new KeyValuePair<string, string>("ypk", "Yupik languages"));
            langs.Add(new KeyValuePair<string, string>("znd", "Zande"));
            langs.Add(new KeyValuePair<string, string>("zap", "Zapotec"));
            langs.Add(new KeyValuePair<string, string>("zen", "Zenaga"));
            langs.Add(new KeyValuePair<string, string>("zha", "Zhuang"));
            langs.Add(new KeyValuePair<string, string>("zul", "Zulu"));
            langs.Add(new KeyValuePair<string, string>("zun", "Zuni"));
            return langs;
        }

        public static string GetName(string code)
        {
            return GetLanguages().Where(l => l.Key == code
              || l.Key == "und").First().Value;
        }

    }
}
