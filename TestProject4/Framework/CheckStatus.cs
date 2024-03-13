static class CheckStatus
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="requst"></param>
    /// <param name="status"></param>
    /// <returns></returns>
    public static bool CheckStatusBool(RestResponse requst, int status = 200)
    {
        bool check = (int)requst.StatusCode == status ? true : false;
        return check;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="requst"></param>
    /// <param name="status"></param>
    public static void ChecksStatus(RestResponse requst, int status = 200)
    {

        Assert.IsTrue((int)requst.StatusCode == status, $"Статус код не соответствует {status}");
    }
}

