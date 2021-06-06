namespace Portfolio.Standard.Models
{
    public enum LoggingEvents
	{
		GENERATE_ITEMS = 1000,
		LIST_ITEMS = 1001,
		GET_ITEM,
		INSERT_ITEM,
		UPDATE_ITEM,
		DELETE_ITEM,
		LOGIN_ITEM,
		EXCEPTION_ITEM,
		ACTIVITY_LOG_MESSAGE,
        HUB_CONNECTION_ERROR
	}
}
