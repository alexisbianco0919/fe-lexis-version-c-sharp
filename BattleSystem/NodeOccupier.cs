class NodeOccupier
{
    private string _occupier_name = "Lex";
    public string OccupierName
    {
        get
        {
            return _occupier_name;
        }
        set
        {
            _occupier_name = value;
        }
    }

    private string _class_type = "INFANTRY";
    public string ClassType
    {
        get
        {
            return _class_type;
        }
        set
        {
            _class_type = value;
        }
    }
}