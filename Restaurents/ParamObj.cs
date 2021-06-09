namespace Restaurents
{
    public class ParamObj
    {
        public ParamObj()
        {

        }
        public ParamObj(string name,object value)
        {
            this.Name = name;
            this.Value = value;
            this.Type = ParamType.String;
        }
        public ParamObj(string name, object value, ParamType type)
        {
            this.Name = name;
            this.Value = value;
            this.Type = type;
        }
        public string Name { get; set; }
        public object Value { get; set; }
        public ParamType Type { get; set; }
    }
}
