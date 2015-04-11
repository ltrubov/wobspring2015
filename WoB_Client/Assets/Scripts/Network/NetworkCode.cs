﻿public class NetworkCode {
	
	// Request + Response
	public static readonly short CLIENT = 100;
	public static readonly short HEARTBEAT = 101;
	public static readonly short ACTIVITY = 102;
	public static readonly short LOGIN = 103;
	public static readonly short LOGOUT = 104;
	public static readonly short REGISTER = 105;
	public static readonly short ERROR_LOG = 106;
	public static readonly short MESSAGE = 107;
	
	public static readonly short PLAYERS = 108;
	public static readonly short SPECIES_LIST = 109;
	public static readonly short WORLD = 110;
	public static readonly short ZONE_LIST = 111;
	public static readonly short ZONE = 112;
	public static readonly short ZONE_UPDATE = 113;
	public static readonly short ECOSYSTEM = 114;
	public static readonly short PREDICTION = 115;
	
	public static readonly short SHOP = 116;
	public static readonly short SHOP_ACTION = 117;
	public static readonly short PARAMS = 118;
	public static readonly short CHANGE_PARAMETERS = 119;
	public static readonly short GET_FUNCTIONAL_PARAMETERS = 120;
	public static readonly short CHANGE_FUNCTIONAL_PARAMETERS = 121;
	public static readonly short STATISTICS = 122;
	public static readonly short HIGH_SCORE = 123;
	public static readonly short CHART = 124;
	public static readonly short SPECIES_ACTION = 125;
	public static readonly short BADGE_LIST = 126;
	
	public static readonly short BATTLE_REQ = 127;
	public static readonly short BATTLE_PREP = 128;
	public static readonly short SEASON_CHANGE = 129;
	public static readonly short BATTLE_CON = 130;
	public static readonly short BATTLE_ACTION = 131;
	public static readonly short BATTLE_TURN = 132;
	public static readonly short BATTLE_START = 133;
	
	public static readonly short UPDATE_RESOURCES = 134;
	public static readonly short SPECIES_KILL = 135;
	public static readonly short UPDATE_TIME = 136;
	public static readonly short SPECIES_CREATE = 137;
	public static readonly short OBJECTIVE_ACTION = 138;
	public static readonly short UPDATE_ENV_SCORE = 139;
	public static readonly short UPDATE_LEVEL = 140;
	public static readonly short BADGE_UPDATE = 141;
	public static readonly short UPDATE_SEASON = 142;
	public static readonly short UPDATE_CURRENT_EVENT = 143;
	public static readonly short BATTLE_END = 144;

	public static readonly short PLAYER_SELECT = 145;

	public static readonly short CONVERGE_ECOSYSTEMS = 146;
	public static readonly short CONVERGE_NEW_ATTEMPT = 147;
	public static readonly short CONVERGE_PRIOR_ATTEMPT = 148;
	public static readonly short CONVERGE_PRIOR_ATTEMPT_COUNT = 149;
	public static readonly short CONVERGE_HINT = 150;
	public static readonly short CONVERGE_HINT_COUNT = 151;
	public static readonly short CONVERGE_NEW_ATTEMPT_SCORE = 152;

	public static readonly short CLASH_ENTRY = 153;
	public static readonly short CLASH_SPECIES_LIST = 154;
	public static readonly short CLASH_DEFENSE_SETUP = 155;
	public static readonly short CLASH_PLAYER_LIST = 156;
	public static readonly short CLASH_PLAYER_VIEW = 157;
	public static readonly short CLASH_INITIATE_BATTLE = 158;
	public static readonly short CLASH_END_BATTLE = 159;
}
