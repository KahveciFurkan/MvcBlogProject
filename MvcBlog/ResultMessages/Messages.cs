namespace MvcBlog.ResultMessages
{
    public static class Messages
    {
        public static class Article
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
        public static class Category
        {
            public static string Add(string categoryName)
            {
                return $"{categoryName} başlıklı kategori eklenmiştir.";
            }
            public static string Update(string categoryName)
            {
                return $"{categoryName} başlıklı kategori güncellenmiştir.";
            }
            public static string Delete(string categoryName)
            {
                return $"{categoryName} başlıklı kategori silinmiştir.";
            }
        }
        public static class User
        {
            public static string Add(string UserName)
            {
                return $"{UserName} başlıklı kullanıcı eklenmiştir.";
            }
            public static string Update(string UserName)
            {
                return $"{UserName} başlıklı kullanıcı güncellenmiştir.";
            }
            public static string Delete(string UserName)
            {
                return $"{UserName} başlıklı kullanıcı silinmiştir.";
            }
        }


    }
}
