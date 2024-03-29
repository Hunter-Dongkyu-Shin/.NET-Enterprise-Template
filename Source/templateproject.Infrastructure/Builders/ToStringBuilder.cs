namespace templateproject.Infrastructure.Builders
{
    using System.Linq;
    using System.Text;
    using System.Reflection;

    public static class ToStringBuilder
    {
        /// <summary>
        /// Logging of the object fields
        /// </summary>
        /// <param name="obj">object to log</param>
        /// <returns>string representation</returns>
        public static string ReflectionToString(object obj)
        {
            var sb = new StringBuilder("\r\nLog: ");

            if (obj == null)
                return "Object is null";

            var clazz = obj.GetType();
            sb.AppendFormat("--Type:<{0}>", clazz);

            // TODO : Reflection은 성능상 좋지 않다. Dynamic method나 ThirdPartyLibrary를 이용하도록 변환해야 한다.
            var fields =
                clazz.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic |
                                BindingFlags.GetField);

            foreach (var f in fields.Where(f => f.IsStatic == false))
                sb.AppendFormat("-Field <{0}> value <{1}>", f.Name, f.GetValue(obj) ?? "null");

            return sb.ToString();
        }
    }
}