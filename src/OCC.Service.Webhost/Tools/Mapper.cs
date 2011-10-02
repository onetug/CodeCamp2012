namespace OCC.Service.Webhost.Tools
{
    using System.Reflection;

    public static class Mapper
    {
        public static void CopyProperties(object from, object to)
        {
            foreach (PropertyInfo source in from.GetType().GetProperties())
            {
                PropertyInfo target = to.GetType().GetProperty(source.Name);

                if (target != null)
                {
                    if (source.PropertyType.FullName == target.PropertyType.FullName)
                    {
                        var v = source.GetValue(from, null);
                        target.SetValue(to, v, null);
                    }
                    else
                    {
                        var a = source.GetValue(from, null);
                        var b = target.GetValue(to, null);

                        CopyProperties(a, b);
                    }
                }
            }
        }
    }
}