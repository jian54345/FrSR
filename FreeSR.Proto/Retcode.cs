namespace FreeSR.Proto
{
	public static class Retcode
	{
		public const int RETCODE_RET_SUCC = 0;
		public const int RETCODE_RET_FAIL = 1;
		public const int RETCODE_RET_SERVER_INTERNAL_ERROR = 2;
		public const int RETCODE_RET_TIMEOUT = 3;
		public const int RETCODE_RET_REPEATED_REQ = 4;
		public const int RETCODE_RET_REQ_PARA_INVALID = 5;
		public const int RETCODE_RET_PLAYER_DATA_ERROR = 6;
		public const int RETCODE_RET_PLAYER_CLIENT_PAUSED = 7;
		public const int RETCODE_RET_FUNC_CHECK_FAILED = 8;
		public const int RETCODE_RET_FEATURE_SWITCH_CLOSED = 9;
		public const int RETCODE_RET_FREQ_OVER_LIMIT = 10;
		public const int RETCODE_RET_SYSTEM_BUSY = 11;
		public const int RETCODE_RET_REPEATE_LOGIN = 1000;
		public const int RETCODE_RET_RETRY_LOGIN = 1001;
		public const int RETCODE_RET_WAIT_LOGIN = 1002;
		public const int RETCODE_RET_NOT_IN_WHITE_LIST = 1003;
		public const int RETCODE_RET_IN_BLACK_LIST = 1004;
		public const int RETCODE_RET_ACCOUNT_VERIFY_ERROR = 1005;
		public const int RETCODE_RET_ACCOUNT_PARA_ERROR = 1006;
		public const int RETCODE_RET_ANTI_ADDICT_LOGIN = 1007;
		public const int RETCODE_RET_CHECK_SUM_ERROR = 1008;
		public const int RETCODE_RET_REACH_MAX_PLAYER_NUM = 1009;
		public const int RETCODE_RET_ALREADY_REGISTERED = 1010;
		public const int RETCODE_RET_GENDER_ERROR = 1011;
		public const int RETCODE_SET_NICKNAME_RET_CALLBACK_PROCESSING = 1012;
		public const int RETCODE_RET_IN_GM_BIND_ACCESS = 1013;
		public const int RETCODE_RET_QUEST_REWARD_ALREADY_TAKEN = 1100;
		public const int RETCODE_RET_QUEST_NOT_ACCEPT = 1101;
		public const int RETCODE_RET_QUEST_NOT_FINISH = 1102;
		public const int RETCODE_RET_QUEST_STATUS_ERROR = 1103;
		public const int RETCODE_RET_ACHIEVEMENT_LEVEL_NOT_REACH = 1104;
		public const int RETCODE_RET_ACHIEVEMENT_LEVEL_ALREADY_TAKEN = 1105;
		public const int RETCODE_RET_AVATAR_NOT_EXIST = 1200;
		public const int RETCODE_RET_AVATAR_RES_EXP_NOT_ENOUGH = 1201;
		public const int RETCODE_RET_AVATAR_EXP_REACH_PROMOTION_LIMIT = 1202;
		public const int RETCODE_RET_AVATAR_REACH_MAX_PROMOTION = 1203;
		public const int RETCODE_RET_SKILLTREE_CONFIG_NOT_EXIST = 1204;
		public const int RETCODE_RET_SKILLTREE_ALREADY_UNLOCK = 1205;
		public const int RETCODE_RET_SKILLTREE_PRE_LOCKED = 1206;
		public const int RETCODE_RET_SKILLTREE_LEVEL_NOT_MEET = 1207;
		public const int RETCODE_RET_SKILLTREE_RANK_NOT_MEET = 1208;
		public const int RETCODE_RET_AVATAR_DRESS_NO_EQUIPMENT = 1209;
		public const int RETCODE_RET_AVATAR_EXP_ITEM_NOT_EXIST = 1210;
		public const int RETCODE_RET_SKILLTREE_POINT_UNLOCK = 1211;
		public const int RETCODE_RET_SKILLTREE_POINT_LEVEL_UPGRADE_NOT_MATCH = 1212;
		public const int RETCODE_RET_SKILLTREE_POINT_LEVEL_REACH_MAX = 1213;
		public const int RETCODE_RET_WORLD_LEVEL_NOT_MEET = 1214;
		public const int RETCODE_RET_PLAYER_LEVEL_NOT_MEET = 1215;
		public const int RETCODE_RET_AVATAR_RANK_NOT_MATCH = 1216;
		public const int RETCODE_RET_AVATAR_RANK_REACH_MAX = 1217;
		public const int RETCODE_RET_HERO_BASIC_TYPE_NOT_MATCH = 1218;
		public const int RETCODE_RET_AVATAR_PROMOTION_NOT_MEET = 1219;
		public const int RETCODE_RET_PROMOTION_REWARD_CONFIG_NOT_EXIST = 1220;
		public const int RETCODE_RET_PROMOTION_REWARD_ALREADY_TAKEN = 1221;
		public const int RETCODE_RET_ITEM_NOT_EXIST = 1300;
		public const int RETCODE_RET_ITEM_COST_NOT_ENOUGH = 1301;
		public const int RETCODE_RET_ITEM_COST_TOO_MUCH = 1302;
		public const int RETCODE_RET_ITEM_NO_COST = 1303;
		public const int RETCODE_RET_ITEM_NOT_ENOUGH = 1304;
		public const int RETCODE_RET_ITEM_INVALID = 1305;
		public const int RETCODE_RET_ITEM_CONFIG_NOT_EXIST = 1306;
		public const int RETCODE_RET_SCOIN_NOT_ENOUGH = 1307;
		public const int RETCODE_RET_ITEM_REWARD_EXCEED_LIMIT = 1308;
		public const int RETCODE_RET_ITEM_INVALID_USE = 1309;
		public const int RETCODE_RET_ITEM_USE_CONFIG_NOT_EXIST = 1310;
		public const int RETCODE_RET_REWARD_CONFIG_NOT_EXIST = 1311;
		public const int RETCODE_RET_ITEM_EXCEED_LIMIT = 1312;
		public const int RETCODE_RET_ITEM_COUNT_INVALID = 1313;
		public const int RETCODE_RET_ITEM_USE_TARGET_TYPE_INVALID = 1314;
		public const int RETCODE_RET_ITEM_USE_SATIETY_FULL = 1315;
		public const int RETCODE_RET_ITEM_COMPOSE_NOT_EXIST = 1316;
		public const int RETCODE_RET_RELIC_COMPOSE_NOT_EXIST = 1317;
		public const int RETCODE_RET_ITEM_CAN_NOT_SELL = 1318;
		public const int RETCODE_RET_ITEM_SELL_EXCEDD_LIMIT = 1319;
		public const int RETCODE_RET_ITEM_NOT_IN_COST_LIST = 1320;
		public const int RETCODE_RET_ITEM_SPECIAL_COST_NOT_ENOUGH = 1321;
		public const int RETCODE_RET_ITEM_SPECIAL_COST_TOO_MUCH = 1322;
		public const int RETCODE_RET_ITEM_FORMULA_NOT_EXIST = 1323;
		public const int RETCODE_RET_ITEM_AUTO_GIFT_OPTIONAL_NOT_EXIST = 1324;
		public const int RETCODE_RET_RELIC_COMPOSE_RELIC_INVALID = 1325;
		public const int RETCODE_RET_RELIC_COMPOSE_MAIN_AFFIX_ID_INVALID = 1326;
		public const int RETCODE_RET_RELIC_COMPOSE_WRONG_FORMULA_TYPE = 1327;
		public const int RETCODE_RET_RELIC_COMPOSE_RELIC_NOT_EXIST = 1328;
		public const int RETCODE_RET_RELIC_COMPOSE_BLACK_GOLD_COUNT_INVALID = 1329;
		public const int RETCODE_RET_RELIC_COMPOSE_BLACK_GOLD_NOT_NEED = 1330;
		public const int RETCODE_RET_MONTH_CARD_CANNOT_USE = 1331;
		public const int RETCODE_RET_ITEM_REWARD_EXCEED_DISAPPEAR = 1332;
		public const int RETCODE_RET_ITEM_NEED_RECYCLE = 1333;
		public const int RETCODE_RET_ITEM_COMPOSE_EXCEED_LIMIT = 1334;
		public const int RETCODE_RET_EQUIPMENT_ALREADY_DRESSED = 1350;
		public const int RETCODE_RET_EQUIPMENT_NOT_EXIST = 1351;
		public const int RETCODE_RET_EQUIPMENT_REACH_LEVEL_LIMIT = 1352;
		public const int RETCODE_RET_EQUIPMENT_CONSUME_SELF = 1353;
		public const int RETCODE_RET_EQUIPMENT_ALREADY_LOCKED = 1354;
		public const int RETCODE_RET_EQUIPMENT_ALREADY_UNLOCKED = 1355;
		public const int RETCODE_RET_EQUIPMENT_LOCKED = 1356;
		public const int RETCODE_RET_EQUIPMENT_SELECT_NUM_OVER_LIMIT = 1357;
		public const int RETCODE_RET_EQUIPMENT_RANK_UP_MUST_CONSUME_SAME_TID = 1358;
		public const int RETCODE_RET_EQUIPMENT_PROMOTION_REACH_MAX = 1359;
		public const int RETCODE_RET_EQUIPMENT_RANK_UP_REACH_MAX = 1360;
		public const int RETCODE_RET_EQUIPMENT_LEVEL_REACH_MAX = 1361;
		public const int RETCODE_RET_EQUIPMENT_EXCEED_LIMIT = 1362;
		public const int RETCODE_RET_RELIC_NOT_EXIST = 1363;
		public const int RETCODE_RET_RELIC_REACH_LEVEL_LIMIT = 1364;
		public const int RETCODE_RET_RELIC_CONSUME_SELF = 1365;
		public const int RETCODE_RET_RELIC_ALREADY_DRESSED = 1366;
		public const int RETCODE_RET_RELIC_LOCKED = 1367;
		public const int RETCODE_RET_RELIC_ALREADY_LOCKED = 1368;
		public const int RETCODE_RET_RELIC_ALREADY_UNLOCKED = 1369;
		public const int RETCODE_RET_RELIC_LEVEL_IS_NOT_ZERO = 1370;
		public const int RETCODE_RET_UNIQUE_ID_REPEATED = 1371;
		public const int RETCODE_RET_EQUIPMENT_LEVEL_NOT_MEET = 1372;
		public const int RETCODE_RET_EQUIPMENT_ITEM_NOT_IN_COST_LIST = 1373;
		public const int RETCODE_RET_EQUIPMENT_LEVEL_GREATER_THAN_ONE = 1374;
		public const int RETCODE_RET_EQUIPMENT_ALREADY_RANKED = 1375;
		public const int RETCODE_RET_RELIC_EXCEED_LIMIT = 1376;
		public const int RETCODE_RET_LINEUP_INVALID_INDEX = 1400;
		public const int RETCODE_RET_LINEUP_INVALID_MEMBER_POS = 1401;
		public const int RETCODE_RET_LINEUP_SWAP_NOT_EXIST = 1402;
		public const int RETCODE_RET_LINEUP_AVATAR_ALREADY_IN = 1403;
		public const int RETCODE_RET_LINEUP_CREATE_AVATAR_ERROR = 1404;
		public const int RETCODE_RET_LINEUP_AVATAR_INIT_ERROR = 1405;
		public const int RETCODE_RET_LINEUP_NOT_EXIST = 1406;
		public const int RETCODE_RET_LINEUP_ONLY_ONE_MEMBER = 1407;
		public const int RETCODE_RET_LINEUP_SAME_LEADER_SLOT = 1408;
		public const int RETCODE_RET_LINEUP_NO_LEADER_SELECT = 1409;
		public const int RETCODE_RET_LINEUP_SWAP_SAME_SLOT = 1410;
		public const int RETCODE_RET_LINEUP_AVATAR_NOT_EXIST = 1411;
		public const int RETCODE_RET_LINEUP_TRIAL_AVATAR_CAN_NOT_QUIT = 1412;
		public const int RETCODE_RET_LINEUP_VIRTUAL_LINEUP_PLANE_NOT_MATCH = 1413;
		public const int RETCODE_RET_LINEUP_NOT_VALID_LEADER = 1414;
		public const int RETCODE_RET_LINEUP_SAME_INDEX = 1415;
		public const int RETCODE_RET_LINEUP_IS_EMPTY = 1416;
		public const int RETCODE_RET_LINEUP_NAME_FORMAT_ERROR = 1417;
		public const int RETCODE_RET_LINEUP_TYPE_NOT_MATCH = 1418;
		public const int RETCODE_RET_LINEUP_REPLACE_ALL_FAILED = 1419;
		public const int RETCODE_RET_LINEUP_NOT_ALLOW_EDIT = 1420;
		public const int RETCODE_RET_LINEUP_AVATAR_IS_ALIVE = 1421;
		public const int RETCODE_RET_LINEUP_ASSIST_HAS_ONLY_MEMBER = 1422;
		public const int RETCODE_RET_LINEUP_ASSIST_CANNOT_SWITCH = 1423;
		public const int RETCODE_RET_LINEUP_AVATAR_TYPE_INVALID = 1424;
		public const int RETCODE_RET_LINEUP_NAME_UTF8_ERROR = 1425;
		public const int RETCODE_RET_LINEUP_LEADER_LOCK = 1426;
		public const int RETCODE_RET_MAIL_NOT_EXIST = 1700;
		public const int RETCODE_RET_MAIL_RANGE_INVALID = 1701;
		public const int RETCODE_RET_MAIL_MAIL_ID_INVALID = 1702;
		public const int RETCODE_RET_MAIL_NO_MAIL_TAKE_ATTACHMENT = 1703;
		public const int RETCODE_RET_MAIL_NO_MAIL_TO_DEL = 1704;
		public const int RETCODE_RET_MAIL_TYPE_INVALID = 1705;
		public const int RETCODE_RET_MAIL_PARA_INVALID = 1706;
		public const int RETCODE_RET_MAIL_ATTACHEMENT_INVALID = 1707;
		public const int RETCODE_RET_MAIL_TICKET_INVALID = 1708;
		public const int RETCODE_RET_MAIL_TICKET_REPEATED = 1709;
		public const int RETCODE_RET_STAGE_SETTLE_ERROR = 1800;
		public const int RETCODE_RET_STAGE_CONFIG_NOT_EXIST = 1801;
		public const int RETCODE_RET_STAGE_NOT_FOUND = 1802;
		public const int RETCODE_RET_STAGE_COCOON_PROP_NOT_VALID = 1804;
		public const int RETCODE_RET_STAGE_COCOON_WAVE_NOT_VALID = 1805;
		public const int RETCODE_RET_STAGE_PROP_ID_NOT_EQUAL = 1806;
		public const int RETCODE_RET_STAGE_COCOON_WAVE_OVER = 1807;
		public const int RETCODE_RET_STAGE_WEEK_COCOON_OVER_CNT = 1808;
		public const int RETCODE_RET_STAGE_COCOON_NOT_OPEN = 1809;
		public const int RETCODE_RET_STAGE_TRIAL_NOT_OPEN = 1810;
		public const int RETCODE_RET_CHAPTER_LOCK = 1900;
		public const int RETCODE_RET_CHAPTER_CHALLENGE_NUM_NOT_ENOUGH = 1901;
		public const int RETCODE_RET_CHAPTER_REWARD_ID_NOT_EXIST = 1902;
		public const int RETCODE_RET_CHAPTER_REWARD_ALREADY_TAKEN = 1903;
		public const int RETCODE_RET_BATTLE_STAGE_NOT_MATCH = 2000;
		public const int RETCODE_RET_IN_BATTLE_NOW = 2001;
		public const int RETCODE_RET_BATTLE_CHEAT = 2002;
		public const int RETCODE_RET_BATTLE_FAIL = 2003;
		public const int RETCODE_RET_BATTLE_NO_LINEUP = 2004;
		public const int RETCODE_RET_BATTLE_LINEUP_EMPTY = 2005;
		public const int RETCODE_RET_BATTLE_VERSION_NOT_MATCH = 2006;
		public const int RETCODE_RET_BATTLE_QUIT_BY_SERVER = 2007;
		public const int RETCODE_RET_IN_BATTLE_CHECK = 2008;
		public const int RETCODE_RET_BATTLE_CHECK_NEED_RETRY = 2009;
		public const int RETCODE_RET_BATTLE_COST_TIME_CHECK_FAIL = 2010;
		public const int RETCODE_RET_LACK_EXCHANGE_STAMINA_TIMES = 2100;
		public const int RETCODE_RET_LACK_STAMINA = 2101;
		public const int RETCODE_RET_STAMINA_FULL = 2102;
		public const int RETCODE_RET_AUTHKEY_SIGN_TYPE_ERROR = 2103;
		public const int RETCODE_RET_AUTHKEY_SIGN_VER_ERROR = 2104;
		public const int RETCODE_RET_NICKNAME_FORMAT_ERROR = 2105;
		public const int RETCODE_RET_SENSITIVE_WORDS = 2106;
		public const int RETCODE_RET_LEVEL_REWARD_HAS_TAKEN = 2107;
		public const int RETCODE_RET_LEVEL_REWARD_LEVEL_ERROR = 2108;
		public const int RETCODE_RET_LANGUAGE_INVALID = 2109;
		public const int RETCODE_RET_NICKNAME_IN_CD = 2110;
		public const int RETCODE_RET_GAMEPLAY_BIRTHDAY_INVALID = 2111;
		public const int RETCODE_RET_GAMEPLAY_BIRTHDAY_ALREADY_SET = 2112;
		public const int RETCODE_RET_NICKNAME_UTF8_ERROR = 2113;
		public const int RETCODE_RET_NICKNAME_DIGIT_LIMIT_ERROR = 2114;
		public const int RETCODE_RET_SENSITIVE_WORDS_PLATFORM_ERROR = 2115;
		public const int RETCODE_RET_MAZE_LACK_TICKET = 2201;
		public const int RETCODE_RET_MAZE_NOT_UNLOCK = 2202;
		public const int RETCODE_RET_MAZE_NO_ABILITY = 2204;
		public const int RETCODE_RET_MAZE_NO_PLANE = 2205;
		public const int RETCODE_RET_MAZE_MAP_NOT_EXIST = 2207;
		public const int RETCODE_RET_MAZE_MP_NOT_ENOUGH = 2213;
		public const int RETCODE_RET_SPRING_NOT_ENABLE = 2214;
		public const int RETCODE_RET_SPRING_TOO_FAR = 2216;
		public const int RETCODE_RET_NOT_IN_MAZE = 2218;
		public const int RETCODE_RET_MAZE_TIME_OF_DAY_TYPE_ERROR = 2223;
		public const int RETCODE_RET_PLOT_NOT_UNLOCK = 2300;
		public const int RETCODE_RET_MISSION_NOT_EXIST = 2400;
		public const int RETCODE_RET_MISSION_ALREADY_DONE = 2401;
		public const int RETCODE_RET_DAILY_TASK_NOT_FINISH = 2402;
		public const int RETCODE_RET_DAILY_TASK_REWARD_HAS_TAKEN = 2403;
		public const int RETCODE_RET_MISSION_NOT_FINISH = 2404;
		public const int RETCODE_RET_MISSION_NOT_DOING = 2405;
		public const int RETCODE_RET_MISSION_FINISH_WAY_NOT_MATCH = 2406;
		public const int RETCODE_RET_MISSION_SCENE_NOT_MATCH = 2407;
		public const int RETCODE_RET_MISSION_CUSTOM_VALUE_NOT_VALID = 2408;
		public const int RETCODE_RET_MISSION_SUB_MISSION_NOT_MATCH = 2409;
		public const int RETCODE_RET_ADVENTURE_MAP_NOT_EXIST = 2500;
		public const int RETCODE_RET_SCENE_ENTITY_NOT_EXIST = 2600;
		public const int RETCODE_RET_NOT_IN_SCENE = 2601;
		public const int RETCODE_RET_SCENE_MONSTER_NOT_EXIST = 2602;
		public const int RETCODE_RET_INTERACT_CONFIG_NOT_EXIST = 2603;
		public const int RETCODE_RET_UNSUPPORTED_PROP_STATE = 2604;
		public const int RETCODE_RET_SCENE_ENTRY_ID_NOT_MATCH = 2605;
		public const int RETCODE_RET_SCENE_ENTITY_MOVE_CHECK_FAILED = 2606;
		public const int RETCODE_RET_ASSIST_MONSTER_COUNT_LIMIT = 2607;
		public const int RETCODE_RET_SCENE_USE_SKILL_FAIL = 2608;
		public const int RETCODE_RET_PROP_IS_HIDDEN = 2609;
		public const int RETCODE_RET_LOADING_SUCC_ALREADY = 2610;
		public const int RETCODE_RET_SCENE_ENTITY_TYPE_INVALID = 2611;
		public const int RETCODE_RET_INTERACT_TYPE_INVALID = 2612;
		public const int RETCODE_RET_INTERACT_NOT_IN_REGION = 2613;
		public const int RETCODE_RET_INTERACT_SUB_TYPE_INVALID = 2614;
		public const int RETCODE_RET_NOT_LEADER_ENTITY = 2615;
		public const int RETCODE_RET_MONSTER_IS_NOT_FARM_ELEMENT = 2616;
		public const int RETCODE_RET_MONSTER_CONFIG_NOT_EXIST = 2617;
		public const int RETCODE_RET_AVATAR_HP_ALREADY_FULL = 2618;
		public const int RETCODE_RET_CUR_INTERACT_ENTITY_NOT_MATCH = 2619;
		public const int RETCODE_RET_PLANE_TYPE_NOT_ALLOW = 2620;
		public const int RETCODE_RET_GROUP_NOT_EXIST = 2621;
		public const int RETCODE_RET_GROUP_SAVE_DATA_IN_CD = 2622;
		public const int RETCODE_RET_GROUP_SAVE_LENGH_REACH_MAX = 2623;
		public const int RETCODE_RET_RECENT_ELEMENT_NOT_EXIST = 2624;
		public const int RETCODE_RET_RECENT_ELEMENT_STAGE_NOT_MATCH = 2625;
		public const int RETCODE_RET_SCENE_POSITION_VERSION_NOT_MATCH = 2626;
		public const int RETCODE_RET_BUY_TIMES_LIMIT = 2700;
		public const int RETCODE_RET_BUY_LIMIT_TYPE = 2701;
		public const int RETCODE_RET_SHOP_NOT_OPEN = 2702;
		public const int RETCODE_RET_GOODS_NOT_OPEN = 2703;
		public const int RETCODE_RET_CITY_LEVEL_REWARD_TAKEN = 2704;
		public const int RETCODE_RET_CITY_LEVEL_NOT_MEET = 2705;
		public const int RETCODE_RET_SINGLE_BUY_LIMIT = 2706;
		public const int RETCODE_RET_TUTORIAL_NOT_UNLOCK = 2751;
		public const int RETCODE_RET_TUTORIAL_UNLOCK_ALREADY = 2752;
		public const int RETCODE_RET_TUTORIAL_FINISH_ALREADY = 2753;
		public const int RETCODE_RET_TUTORIAL_PRE_NOT_UNLOCK = 2754;
		public const int RETCODE_RET_TUTORIAL_PLAYER_LEVEL_NOT_MATCH = 2755;
		public const int RETCODE_RET_TUTORIAL_TUTORIAL_NOT_FOUND = 2756;
		public const int RETCODE_RET_CHALLENGE_NOT_EXIST = 2801;
		public const int RETCODE_RET_CHALLENGE_NOT_UNLOCK = 2802;
		public const int RETCODE_RET_CHALLENGE_ALREADY = 2803;
		public const int RETCODE_RET_CHALLENGE_LINEUP_EDIT_FORBIDDEN = 2804;
		public const int RETCODE_RET_CHALLENGE_LINEUP_EMPTY = 2805;
		public const int RETCODE_RET_CHALLENGE_NOT_DOING = 2806;
		public const int RETCODE_RET_CHALLENGE_NOT_FINISH = 2807;
		public const int RETCODE_RET_CHALLENGE_TARGET_NOT_FINISH = 2808;
		public const int RETCODE_RET_CHALLENGE_TARGET_REWARD_TAKEN = 2809;
		public const int RETCODE_RET_CHALLENGE_TIME_NOT_VALID = 2810;
		public const int RETCODE_RET_CHALLENGE_STARS_COUNT_NOT_MEET = 2811;
		public const int RETCODE_RET_CHALLENGE_STARS_REWARD_TAKEN = 2812;
		public const int RETCODE_RET_CHALLENGE_STARS_NOT_EXIST = 2813;
		public const int RETCODE_RET_BASIC_TYPE_ALREADY = 2850;
		public const int RETCODE_RET_NO_BASIC_TYPE = 2851;
		public const int RETCODE_RET_NOT_CHOOSE_BASIC_TYPE = 2852;
		public const int RETCODE_RET_NOT_FUNC_CLOSE = 2853;
		public const int RETCODE_RET_NOT_CHOOSE_GENDER = 2854;
		public const int RETCODE_RET_ROGUE_STATUS_NOT_MATCH = 2901;
		public const int RETCODE_RET_ROGUE_SELECT_BUFF_NOT_EXIST = 2902;
		public const int RETCODE_RET_ROGUE_COIN_NOT_ENOUGH = 2903;
		public const int RETCODE_RET_ROGUE_STAMINA_NOT_ENOUGH = 2904;
		public const int RETCODE_RET_ROGUE_APPRAISAL_COUNT_NOT_ENOUGH = 2905;
		public const int RETCODE_RET_ROGUE_PROP_ALREADY_USED = 2906;
		public const int RETCODE_RET_ROGUE_RECORD_ALREADY_SAVED = 2907;
		public const int RETCODE_RET_ROGUE_ROLL_BUFF_MAX_COUNT = 2908;
		public const int RETCODE_RET_ROGUE_PICK_AVATAR_INVALID = 2909;
		public const int RETCODE_RET_ROGUE_QUEST_EXPIRE = 2910;
		public const int RETCODE_RET_ROGUE_QUEST_REWARD_ALREADY = 2911;
		public const int RETCODE_RET_ROGUE_REVIVE_COUNT_NOT_ENOUGH = 2912;
		public const int RETCODE_RET_ROGUE_AREA_INVALID = 2913;
		public const int RETCODE_RET_ROGUE_SCORE_REWARD_POOL_INVALID = 2914;
		public const int RETCODE_RET_ROGUE_SCORE_REWARD_ROW_INVALID = 2915;
		public const int RETCODE_RET_ROGUE_AEON_LEVEL_NOT_MEET = 2916;
		public const int RETCODE_RET_ROGUE_AEON_LEVEL_REWARD_ALREADY_TAKEN = 2917;
		public const int RETCODE_RET_ROGUE_AEON_CONFIG_NOT_EXIST = 2918;
		public const int RETCODE_RET_ROGUE_TRIAL_AVATAR_INVALID = 2919;
		public const int RETCODE_RET_ROGUE_HANDBOOK_REWARD_ALREADY_TAKEN = 2920;
		public const int RETCODE_RET_MISSION_EVENT_CONFIG_NOT_EXIST = 2951;
		public const int RETCODE_RET_MISSION_EVENT_NOT_CLIENT = 2952;
		public const int RETCODE_RET_MISSION_EVENT_FINISHED = 2953;
		public const int RETCODE_RET_MISSION_EVENT_DOING = 2954;
		public const int RETCODE_RET_HAS_CHALLENGE_MISSION_EVENT = 2955;
		public const int RETCODE_RET_NOT_CHALLENGE_MISSION_EVENT = 2956;
		public const int RETCODE_RET_GACHA_ID_NOT_EXIST = 3001;
		public const int RETCODE_RET_GACHA_NUM_INVALID = 3002;
		public const int RETCODE_RET_GACHA_FIRST_GACHA_MUST_ONE = 3003;
		public const int RETCODE_RET_GACHA_REQ_DUPLICATED = 3004;
		public const int RETCODE_RET_GACHA_NOT_IN_SCHEDULE = 3005;
		public const int RETCODE_RET_GACHA_NEWBIE_CLOSE = 3006;
		public const int RETCODE_RET_GACHA_TODAY_LIMITED = 3007;
		public const int RETCODE_RET_GACHA_NOT_SUPPORT = 3008;
		public const int RETCODE_RET_GACHA_CEILING_NOT_ENOUGH = 3009;
		public const int RETCODE_RET_GACHA_CEILING_CLOSE = 3010;
		public const int RETCODE_RET_NOT_IN_RAID = 3101;
		public const int RETCODE_RET_RAID_DOING = 3102;
		public const int RETCODE_RET_NOT_PROP = 3103;
		public const int RETCODE_RET_RAID_ID_NOT_MATCH = 3104;
		public const int RETCODE_RET_RAID_RESTART_NOT_MATCH = 3105;
		public const int RETCODE_RET_RAID_LIMIT = 3106;
		public const int RETCODE_RET_RAID_AVATAR_LIST_EMPTY = 3107;
		public const int RETCODE_RET_RAID_AVATAR_NOT_EXIST = 3108;
		public const int RETCODE_RET_CHALLENGE_RAID_REWARD_ALREADY = 3109;
		public const int RETCODE_RET_CHALLENGE_RAID_SCORE_NOT_REACH = 3110;
		public const int RETCODE_RET_CHALLENGE_RAID_NOT_OPEN = 3111;
		public const int RETCODE_RET_RAID_FINISHED = 3112;
		public const int RETCODE_RET_RAID_WORLD_LEVEL_NOT_LOCK = 3113;
		public const int RETCODE_RET_RAID_CANNOT_USE_ASSIST = 3114;
		public const int RETCODE_RET_RAID_AVATAR_NOT_MATCH = 3115;
		public const int RETCODE_RET_RAID_CAN_NOT_SAVE = 3116;
		public const int RETCODE_RET_RAID_NO_SAVE = 3117;
		public const int RETCODE_RET_ACTIVITY_RAID_NOT_OPEN = 3118;
		public const int RETCODE_RET_TALK_EVENT_ALREADY_TAKEN = 3151;
		public const int RETCODE_RET_NPC_ALREADY_MEET = 3152;
		public const int RETCODE_RET_NPC_NOT_IN_CONFIG = 3153;
		public const int RETCODE_RET_DIALOGUE_GROUP_DISMATCH = 3154;
		public const int RETCODE_RET_DIALOGUE_EVENT_INVALID = 3155;
		public const int RETCODE_RET_TALK_EVENT_TAKE_PROTO_NOT_MATCH = 3156;
		public const int RETCODE_RET_TALK_EVENT_NOT_VALID = 3157;
		public const int RETCODE_RET_EXPEDITION_CONFIG_NOT_EXIST = 3201;
		public const int RETCODE_RET_EXPEDITION_REWARD_CONFIG_NOT_EXIST = 3202;
		public const int RETCODE_RET_EXPEDITION_NOT_UNLOCKED = 3203;
		public const int RETCODE_RET_EXPEDITION_ALREADY_ACCEPTED = 3204;
		public const int RETCODE_RET_EXPEDITION_REPEATED_AVATAR = 3205;
		public const int RETCODE_RET_AVATAR_ALREADY_DISPATCHED = 3206;
		public const int RETCODE_RET_EXPEDITION_NOT_ACCEPTED = 3207;
		public const int RETCODE_RET_EXPEDITION_NOT_FINISH = 3208;
		public const int RETCODE_RET_EXPEDITION_ALREADY_FINISH = 3209;
		public const int RETCODE_RET_EXPEDITION_TEAM_COUNT_LIMIT = 3210;
		public const int RETCODE_RET_EXPEDITION_AVATAR_NUM_NOT_MATCH = 3211;
		public const int RETCODE_RET_LOGIN_ACTIVITY_HAS_TAKEN = 3301;
		public const int RETCODE_RET_LOGIN_ACTIVITY_DAYS_LACK = 3302;
		public const int RETCODE_RET_TRIAL_ACTIVITY_REWARD_ALREADY_TAKE = 3303;
		public const int RETCODE_RET_TRIAL_ACTIVITY_STAGE_NOT_FINISH = 3304;
		public const int RETCODE_RET_MONSTER_RESEARCH_ACTIVITY_HAS_TAKEN = 3305;
		public const int RETCODE_RET_MONSTER_RESEARCH_ACTIVITY_MATERIAL_NOT_SUBMITTED = 3306;
		public const int RETCODE_RET_MONSTER_RESEARCH_ACTIVITY_MATERIAL_ALREADY_SUBMITTED = 3307;
		public const int RETCODE_RET_MESSAGE_CONFIG_NOT_EXIST = 3501;
		public const int RETCODE_RET_MESSAGE_SECTION_NOT_TAKE = 3502;
		public const int RETCODE_RET_MESSAGE_GROUP_NOT_TAKE = 3503;
		public const int RETCODE_RET_MESSAGE_SECTION_ID_NOT_MATCH = 3504;
		public const int RETCODE_RET_MESSAGE_SECTION_CAN_NOT_FINISH = 3505;
		public const int RETCODE_RET_MESSAGE_ITEM_CAN_NOT_FINISH = 3506;
		public const int RETCODE_RET_MESSAGE_ITEM_RAID_CAN_NOT_FINISH = 3507;
		public const int RETCODE_RET_FRIEND_ALREADY_IS_FRIEND = 3601;
		public const int RETCODE_RET_FRIEND_IS_NOT_FRIEND = 3602;
		public const int RETCODE_RET_FRIEND_APPLY_EXPIRE = 3603;
		public const int RETCODE_RET_FRIEND_IN_BLACKLIST = 3604;
		public const int RETCODE_RET_FRIEND_NOT_IN_BLACKLIST = 3605;
		public const int RETCODE_RET_FRIEND_NUMBER_LIMIT = 3606;
		public const int RETCODE_RET_FRIEND_BLACKLIST_NUMBER_LIMIT = 3607;
		public const int RETCODE_RET_FRIEND_DAILY_APPLY_LIMIT = 3608;
		public const int RETCODE_RET_FRIEND_IN_HANDLE_LIMIT = 3609;
		public const int RETCODE_RET_FRIEND_APPLY_IN_CD = 3610;
		public const int RETCODE_RET_FRIEND_REMARK_NAME_FORMAT_ERROR = 3611;
		public const int RETCODE_RET_FRIEND_PLAYER_NOT_FOUND = 3612;
		public const int RETCODE_RET_FRIEND_IN_TARGET_BLACKLIST = 3613;
		public const int RETCODE_RET_FRIEND_TARGET_NUMBER_LIMIT = 3614;
		public const int RETCODE_RET_ASSIST_QUERY_TOO_FAST = 3615;
		public const int RETCODE_RET_ASSIST_NOT_EXIST = 3616;
		public const int RETCODE_RET_ASSIST_USED_ALREADY = 3617;
		public const int RETCODE_RET_FRIEND_REPORT_REASON_FORMAT_ERROR = 3618;
		public const int RETCODE_RET_FRIEND_REPORT_SENSITIVE_WORDS = 3619;
		public const int RETCODE_RET_ASSIST_USED_TIMES_OVER = 3620;
		public const int RETCODE_RET_ASSIST_QUIT_ALREADY = 3621;
		public const int RETCODE_RET_ASSIST_AVATAR_IN_LINEUP = 3622;
		public const int RETCODE_RET_ASSIST_NO_REWARD = 3623;
		public const int RETCODE_RET_FRIEND_SEARCH_NUM_LIMIT = 3624;
		public const int RETCODE_RET_FRIEND_SEARCH_IN_CD = 3625;
		public const int RETCODE_RET_FRIEND_REMARK_NAME_UTF8_ERROR = 3626;
		public const int RETCODE_RET_FRIEND_REPORT_REASON_UTF8_ERROR = 3627;
		public const int RETCODE_RET_ASSIST_SET_ALREADY = 3628;
		public const int RETCODE_RET_PLAYER_BOARD_HEAD_ICON_NOT_EXIST = 3701;
		public const int RETCODE_RET_PLAYER_BOARD_HEAD_ICON_LOCKED = 3702;
		public const int RETCODE_RET_PLAYER_BOARD_HEAD_ICON_ALREADY_UNLOCKED = 3703;
		public const int RETCODE_RET_PLAYER_BOARD_DISPLAY_AVATAR_NOT_EXIST = 3704;
		public const int RETCODE_RET_PLAYER_BOARD_DISPLAY_AVATAR_EXCEED_LIMIT = 3705;
		public const int RETCODE_RET_PLAYER_BOARD_DISPLAY_REPEATED_AVATAR = 3706;
		public const int RETCODE_RET_PLAYER_BOARD_DISPLAY_AVATAR_SAME_POS = 3707;
		public const int RETCODE_RET_PLAYER_BOARD_DISPLAY_AVATAR_LOCKED = 3708;
		public const int RETCODE_RET_SIGNATURE_LENGTH_EXCEED_LIMIT = 3709;
		public const int RETCODE_RET_SIGNATURE_SENSITIVE_WORDS = 3710;
		public const int RETCODE_RET_PLAYER_BOARD_ASSIST_AVATAR_NOT_EXIST = 3712;
		public const int RETCODE_RET_PLAYER_BOARD_ASSIST_AVATAR_LOCKED = 3713;
		public const int RETCODE_RET_SIGNATURE_UTF8_ERROR = 3714;
		public const int RETCODE_RET_BATTLE_PASS_TIER_NOT_VALID = 3801;
		public const int RETCODE_RET_BATTLE_PASS_LEVEL_NOT_MEET = 3802;
		public const int RETCODE_RET_BATTLE_PASS_REWARD_TAKE_ALREADY = 3803;
		public const int RETCODE_RET_BATTLE_PASS_NOT_PREMIUM = 3804;
		public const int RETCODE_RET_BATTLE_PASS_NOT_DOING = 3805;
		public const int RETCODE_RET_BATTLE_PASS_LEVEL_INVALID = 3806;
		public const int RETCODE_RET_BATTLE_PASS_NOT_UNLOCK = 3807;
		public const int RETCODE_RET_BATTLE_PASS_NO_REWARD = 3808;
		public const int RETCODE_RET_BATTLE_PASS_QUEST_NOT_VALID = 3809;
		public const int RETCODE_RET_BATTLE_PASS_NOT_CHOOSE_OPTIONAL = 3810;
		public const int RETCODE_RET_BATTLE_PASS_NOT_TAKE_REWARD = 3811;
		public const int RETCODE_RET_BATTLE_PASS_OPTIONAL_NOT_VALID = 3812;
		public const int RETCODE_RET_BATTLE_PASS_BUY_ALREADY = 3813;
		public const int RETCODE_RET_BATTLE_PASS_NEAR_END = 3814;
		public const int RETCODE_RET_MUSIC_LOCKED = 3901;
		public const int RETCODE_RET_MUSIC_NOT_EXIST = 3902;
		public const int RETCODE_RET_MUSIC_UNLOCK_FAILED = 3903;
		public const int RETCODE_RET_PUNK_LORD_LACK_SUMMON_TIMES = 4001;
		public const int RETCODE_RET_PUNK_LORD_ATTACKING_MONSTER_LIMIT = 4002;
		public const int RETCODE_RET_PUNK_LORD_MONSTER_NOT_EXIST = 4003;
		public const int RETCODE_RET_PUNK_LORD_MONSTER_ALREADY_SHARED = 4004;
		public const int RETCODE_RET_PUNK_LORD_MONSTER_EXPIRED = 4005;
		public const int RETCODE_RET_PUNK_LORD_SELF_MONSTER_ATTACK_LIMIT = 4006;
		public const int RETCODE_RET_PUNK_LORD_LACK_SUPPORT_TIMES = 4007;
		public const int RETCODE_RET_PUNK_LORD_MONSTER_ALREADY_KILLED = 4008;
		public const int RETCODE_RET_PUNK_LORD_MONSTER_ATTACKER_LIMIT = 4009;
		public const int RETCODE_RET_PUNK_LORD_WORLD_LEVLE_NOT_VALID = 4010;
		public const int RETCODE_RET_PUNK_LORD_REWARD_LEVLE_NOT_EXIST = 4011;
		public const int RETCODE_RET_PUNK_LORD_POINT_NOT_MEET = 4012;
		public const int RETCODE_RET_PUNK_LORD_IN_ATTACKING = 4013;
		public const int RETCODE_RET_PUNK_LORD_OPERATION_IN_CD = 4014;
		public const int RETCODE_RET_PUNK_LORD_REWARD_ALREADY_TAKEN = 4015;
		public const int RETCODE_RET_PUNK_LORD_OVER_BONUS_REWARD_LIMIT = 4016;
		public const int RETCODE_RET_PUNK_LORD_NOT_IN_SCHEDULE = 4017;
		public const int RETCODE_RET_PUNK_LORD_MONSTER_NOT_ATTACKED = 4018;
		public const int RETCODE_RET_PUNK_LORD_MONSTER_NOT_KILLED = 4019;
		public const int RETCODE_RET_PUNK_LORD_MONSTER_KILLED_SCORE_ALREADY_TAKE = 4020;
		public const int RETCODE_RET_PUNK_LORD_REWARD_LEVLE_ALREADY_TAKE = 4021;
		public const int RETCODE_RET_DAILY_ACTIVE_LEVEL_INVALID = 4101;
		public const int RETCODE_RET_DAILY_ACTIVE_LEVEL_REWARD_ALREADY_TAKEN = 4102;
		public const int RETCODE_RET_DAILY_ACTIVE_LEVEL_AP_NOT_ENOUGH = 4103;
		public const int RETCODE_RET_DAILY_MEET_PAM = 4201;
		public const int RETCODE_RET_REPLAY_ID_NOT_MATCH = 4251;
		public const int RETCODE_RET_REPLAY_REQ_NOT_VALID = 4252;
		public const int RETCODE_RET_FIGHT_ACTIVITY_DIFFICULTY_LEVEL_NOT_PASSED = 4301;
		public const int RETCODE_RET_FIGHT_ACTIVITY_DIFFICULTY_LEVEL_REWARD_ALREADY_TAKE = 4302;
		public const int RETCODE_RET_FIGHT_ACTIVITY_STAGE_NOT_OPEN = 4303;
		public const int RETCODE_RET_TRAIN_VISITOR_VISITOR_NOT_EXIST = 4351;
		public const int RETCODE_RET_TRAIN_VISITOR_BEHAVIOR_NOT_EXIST = 4352;
		public const int RETCODE_RET_TRAIN_VISITOR_BEHAVIOR_FINISHED = 4353;
		public const int RETCODE_RET_TEXT_JOIN_UNKNOW_IS_OVERRIDE = 4401;
		public const int RETCODE_RET_TEXT_JOIN_ID_NOT_EXIST = 4402;
		public const int RETCODE_RET_TEXT_JOIN_CAN_NOT_OVERRIDE = 4403;
		public const int RETCODE_RET_TEXT_JOIN_ITEM_ID_ERROR = 4404;
		public const int RETCODE_RET_TEXT_JOIN_SENSITIVE_CHECK_ERROR = 4405;
		public const int RETCODE_RET_TEXT_JOIN_MUST_OVERRIDE = 4406;
		public const int RETCODE_RET_TEXT_JOIN_TEXT_EMPTY = 4407;
		public const int RETCODE_RET_TEXT_JOIN_TEXT_FORMAT_ERROR = 4408;
		public const int RETCODE_RET_TEXT_JOIN_TEXT_UTF8_ERROR = 4409;
		public const int RETCODE_RET_PAM_MISSION_MISSION_ID_ERROR = 4451;
		public const int RETCODE_RET_PAM_MISSION_MISSION_EXPIRE = 4452;
		public const int RETCODE_RET_CHAT_TYPE_NOT_EXIST = 4501;
		public const int RETCODE_RET_MSG_TYPE_NOT_EXIST = 4502;
		public const int RETCODE_RET_CHAT_NO_TARGET_UID = 4503;
		public const int RETCODE_RET_CHAT_MSG_EMPTY = 4504;
		public const int RETCODE_RET_CHAT_MSG_EXCEED_LIMIT = 4505;
		public const int RETCODE_RET_CHAT_MSG_SENSITIVE_CHECK_ERROR = 4506;
		public const int RETCODE_RET_CHAT_MSG_UTF8_ERROR = 4507;
		public const int RETCODE_RET_CHAT_FORBID_SWITCH_OPEN = 4508;
		public const int RETCODE_RET_CHAT_FORBID = 4509;
		public const int RETCODE_RET_CHAT_MSG_INCLUDE_SPECIAL_STR = 4510;
		public const int RETCODE_RET_BOXING_CLUB_CHALLENGE_NOT_OPEN = 4601;
		public const int RETCODE_RET_MUSEUM_NOT_OPEN = 4651;
		public const int RETCODE_RET_MUSEUM_TURN_CNT_NOT_MATCH = 4652;
		public const int RETCODE_RET_MUSEUM_PHASE_NOT_REACH = 4653;
		public const int RETCODE_RET_MUSEUM_UNKNOW_STUFF = 4654;
		public const int RETCODE_RET_MUSEUM_UNKNOW_AREA = 4655;
		public const int RETCODE_RET_MUSEUM_UNKNOW_POS = 4656;
		public const int RETCODE_RET_MUSEUM_STUFF_ALREADY_IN_AREA = 4657;
		public const int RETCODE_RET_MUSEUM_STUFF_NOT_IN_AREA = 4658;
		public const int RETCODE_RET_MUSEUM_GET_NPC_REPEAT = 4659;
		public const int RETCODE_RET_MUSEUM_GET_NPC_UNLOCK = 4660;
		public const int RETCODE_RET_MUSEUM_GET_NPC_NOT_ENOUGH = 4661;
		public const int RETCODE_RET_MUSEUM_CHANGE_STUFF_AREA_ERROR = 4662;
		public const int RETCODE_RET_MUSEUM_NOT_INIT = 4663;
		public const int RETCODE_RET_MUSEUM_EVENT_ERROR = 4664;
		public const int RETCODE_RET_MUSEUM_UNKNOW_CHOOSE_EVENT_ID = 4665;
		public const int RETCODE_RET_MUSEUM_EVENT_ORDER_NOT_MATCH = 4666;
		public const int RETCODE_RET_MUSEUM_EVENT_PHASE_NOT_UNLOCK = 4667;
		public const int RETCODE_RET_MUSEUM_EVENT_MISSION_NOT_FOUND = 4668;
		public const int RETCODE_RET_MUSEUM_AREA_LEVEL_UP_ALREADY = 4669;
		public const int RETCODE_RET_MUSEUM_STUFF_ALREADY_USED = 4670;
		public const int RETCODE_RET_MUSEUM_EVENT_ROUND_NOT_UNLOCK = 4671;
		public const int RETCODE_RET_MUSEUM_STUFF_IN_AREA = 4672;
		public const int RETCODE_RET_MUSEUM_STUFF_DISPATCH = 4673;
		public const int RETCODE_RET_MUSEUM_IS_END = 4674;
		public const int RETCODE_RET_MUSEUM_STUFF_LEAVING = 4675;
		public const int RETCODE_RET_MUSEUM_EVENT_MISSION_NOT_FINISH = 4678;
		public const int RETCODE_RET_MUSEUM_COLLECT_REWARD_NOT_EXIST = 4679;
		public const int RETCODE_RET_MUSEUM_COLLECT_REWARD_ALREADY_TAKEN = 4680;
		public const int RETCODE_RET_MUSEUM_ACCEPT_MISSION_MAX_LIMIT = 4681;
	}
	
}
