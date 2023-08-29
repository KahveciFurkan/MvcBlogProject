namespace MvcBlog.ResultMessages
{
    public static class Messages
    {
        public static string Add(string articleTitle)
        {
            return $"{articleTitle} başlıklı makale eklenmiştir.";
        }
        public static string Update(string articleTitle)
        {
            return $"{articleTitle} başlıklı makale güncellenmiştir.";
        }
        public static string Delete(string articleTitle)
        {
            return $"{articleTitle} başlıklı makale silinmiştir.";
        }
    }
}
