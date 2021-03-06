namespace Base
{
	public enum ErrorCode
	{
		ERR_Success                                   = 0,
		ERR_RpcProxyTimeout                           = 93,
		ERR_RpcProxySendBuffFull                      = 94,
		ERR_RpcProxyConnectFailed                     = 95,
		ERR_RpcProxyDisconnect                        = 96,
		ERR_RpcProxyParseResponseFailed               = 97,
		ERR_ServerRpcTimeout                          = 98,
		ERR_DBError                                   = 100,
		ERR_DBProxyTrace                              = 101,
		ERR_RpcPraseFailed                            = 103,
		ERR_ServerRpcTrace                            = 104,
		ERR_PlayerNotInGate                           = 105,
		ERR_DataTypeNotExists                         = 106,
		ERR_LoadJsonFailed                            = 107,
		ERR_BattleServerNotExists                     = 108,
		ERR_FreeBattleRoomNotMatch                    = 109,
		ERR_LoadPlayerDataFailed                      = 111,
		ERR_AccountPasswdMissMatch                    = 112,
		ERR_GenerateGuidFailed                        = 113,
		ERR_AssetNotEnough                            = 114,
		ERR_CreateBankJournalFailed                   = 115,
		ERR_LogoutTypeDisconnect                      = 116,
		ERR_LogoutTypeKillBySameAccount               = 117,
		ERR_LogoutTypeNormalQuit                      = 118,
		ERR_NoFreeBattleServer                        = 119,
		ERR_CannotFindRpcHandler                      = 121,
		ERR_RpcHandlerTraceback                       = 122,
		ERR_PlayerIsLogouting                         = 123,
		ERR_PlayerIsInLogin                           = 124,
		ERR_PlayerNameNotValid                        = 125,
		ERR_PlayerNameTooLong                         = 126,
		ERR_PlayerNameExists                          = 127,
		ERR_PlayerNameAllDigit                        = 128,
		ERR_PlayerNameSensitive                       = 129,
		ERR_ClientVersionLow                          = 130,
		ERR_UnknowObject                              = 131,
		ERR_PlatinumNotEnough                         = 132,
		ERR_RemotePlayerMethodNotImpl                 = 133,
		ERR_GoldNotEnough                             = 134,
		ERR_FindMapConfigFailed                       = 199,
		ERR_FindMatchConfigFailed                     = 200,
		ERR_MatchConfigError                          = 201,
		ERR_FetchGateInfoFailed                       = 202,
		ERR_NotSuchLoginToken                         = 203,
		ERR_LoginTokenExpired                         = 204,
		ERR_TempAccountMustAlnum                      = 205,
		ERR_UseMatch                                  = 206,
		ERR_MatchPlayerInWrongStatus                  = 207,
		ERR_FetchPlayerNameFailed                     = 208,
		ERR_GateTracebak                              = 209,
		ERR_RemoteClientNoResponse                    = 210,
		ERR_PlayerNotOnline                           = 211,
		ERR_MatchForbitPlayer                         = 212,
		ERR_StoneMounted                              = 213,
		ERR_StoneMountWrongType                       = 214,
		ERR_StoneMountWrongIdex                       = 215,
		ERR_DeckItemOverLimit                         = 216,
		ERR_BoxNotExist                               = 217,
		ERR_WrongRpcName                              = 500,
		ERR_RpcTraceback                              = 501,
		ERR_TableExistsError                          = 1050,
		ERR_MatchNoIdleBattle                         = 3000,
		ERR_MatchPlayerNotExists                      = 3001,
		ERR_MatchLoadScoreFailed                      = 3002,
		ERR_NotGroupOwner                             = 3003,
		ERR_MatchTurnOffByGM                          = 3004,
		ERR_MatchMustInGroup                          = 3005,
		ERR_MatchInWorkTime                           = 3006,
		ERR_MatchFriendNotEnougth                     = 3007,
		ERR_PlayerNoPet                               = 3008,
		ERR_MatchMustPlayXFirst                       = 3008,
		ERR_PlayerShopIdInvalid                       = 3009,
		ERR_FriendPlayerOffline                       = 4000,
		ERR_FriendPlayerNotExists                     = 4001,
		ERR_FriendAlreadyIsFriends                    = 4002,
		ERR_FriendNotFriends                          = 4003,
		ERR_FriendLoadDataFailed                      = 4004,
		ERR_FriendAddGroupFailedSameGroup             = 4005,
		ERR_FriendDelGroupFailedGroupNotExists        = 4006,
		ERR_FriendMoveGroupFailed                     = 4007,
		ERR_FriendCanNotAddSelf                       = 4008,
		ERR_FriendCanNotAddFriendInBlack              = 4009,
		ERR_FriendAddFriendExists                     = 4010,
		ERR_FriendAddFailed                           = 4011,
		ERR_FriendCountExceedLimit                    = 4012,
		ERR_RoomCreateFail                            = 5000,
		ERR_RoomFull                                  = 5001,
		ERR_RoomNotExist                              = 5002,
		ERR_RoomAlreadyStartGame                      = 5003,
		ERR_RoomPassNotCorrect                        = 5004,
		ERR_RoomNotMatch                              = 5005,
		ERR_RoomNotInFighting                         = 5006,
		ERR_RoomPlayerNotExists                       = 5007,
		ERR_RoomPlayerIsOnline                        = 5008,
		ERR_RoomPlayerAlreadyInRoom                   = 5009,
		ERR_RoomNotGroupOwner                         = 5010,
		ERR_RoomNotEnoughSlot                         = 5011,
		ERR_RoomNotRoomOwner                          = 5012,
		ERR_RoomPlayerNotInRoom                       = 5013,
		ERR_PickHeroFailed                            = 5020,
		ERR_PickHeroDisconnect                        = 5021,
		ERR_NotAllPlayerLoadingDone                   = 5022,
		ERR_PickHeroTraceback                         = 5023,
		ERR_NotAllPlayerConnectedBattle               = 5024,
		ERR_SurrenderNotYet                           = 5030,
		ERR_SurrenderEnded                            = 5031,
		ERR_AccountAlreadyExist                       = 5032,
		ERR_AccountNotValid                           = 5033,
		ERR_PasswordNotValid                          = 5034,
		ERR_AccountNotExists                          = 5035,
		ERR_Password2NotSame                          = 5036,
		ERR_CheckCodeNotCorrect                       = 5037,
		ERR_PlayerNotExists                           = 5038,
		ERR_MailNotExists                             = 5040,
		ERR_MailTitleTooLong                          = 5041,
		ERR_MailContentTooLong                        = 5042,
		ERR_RedisError                                = 5043,
		ERR_CantBattleOb                              = 5044,
		ERR_AlreadyInOb                               = 5055,
		ERR_LoginBattleServerRoomGuidError            = 5088,
		ERR_LoginBattleServerNoSuchPlayer             = 5089,
	}
}
