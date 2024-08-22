class GraphNode 
{
    private readonly int _node_id;
    public int NodeId
    {
        get
        {
            return _node_id;
        }
    }

    // current node coordinates
    private int _x;
    public int X
    {
        get
        {
            return _x;
        }
        set
        {
            _x = value;
        }
    }

    private int _y;
    public int Y
    {
        get
        {
            return _y;
        }
        set
        {
            _y = value;
        }
    }

    // neighbors' nodes coordinates
    private GraphNode? _up_node;
    public GraphNode? UpNode 
    {
        get
        {
            return _up_node;
        }
        set 
        {
            _up_node = value;
        }
    }
    private GraphNode? _right_node;
    public GraphNode? RightNode 
    {
        get
        {
            return _right_node;
        }
        set 
        {
            _right_node = value;
        }
    }

    private GraphNode? _down_node;
    public GraphNode? DownNode 
    {
        get
        {
            return _down_node;
        }
        set 
        {
            _down_node = value;
        }
    }

    private GraphNode? _left_node;
    public GraphNode? LeftNode 
    {
        get
        {
            return _left_node;
        }
        set 
        {
            _left_node = value;
        }
    }

    // node occupier information
    private bool _is_occupied_by_unit;
    public bool IsOccupiedByUnit
    {
        get
        {
            return _is_occupied_by_unit;
        }
        set
        {
            _is_occupied_by_unit = value;
        }
    }

    private bool _is_occupied_by_enemy;
    public bool IsOccupiedByEnemy
    {
        get
        {
            return _is_occupied_by_enemy;
        }
        set
        {
            _is_occupied_by_enemy = value;
        }
    }

    private NodeOccupier? _occupier_info;
    public NodeOccupier? OccupierInfo
    {
        get
        {
            return _occupier_info;
        }
        set
        {
            _occupier_info = value;
        }
    }

   // terrain metadata
    private string _terrain_type = "Grassland";
    public string TerrainType 
    {
        get
        {
            return _terrain_type;
        }
        set 
        {
            _terrain_type = value;
        }
    }
    private bool _can_be_traversed_infantry;
    public bool CanBeTraversedInfantry
    {
        get
        {
            return _can_be_traversed_infantry;
        }
        set
        {
            _can_be_traversed_infantry = value;
        }
    }
    private bool _can_be_traversed_armor;
    public bool CanBeTraversedArmor
    {
        get
        {
            return _can_be_traversed_armor;
        }
        set
        {
            _can_be_traversed_armor = value;
        }
    }
    private bool _can_be_traversed_horse;
    public bool CanBeTraversedHorse
    {
        get
        {
            return _can_be_traversed_horse;
        }
        set
        {
            _can_be_traversed_horse = value;
        }
    }
    private bool _can_be_traversed_flyer;
    public bool CanBeTraversedFlyer
    {
        get
        {
            return _can_be_traversed_flyer;
        }
        set
        {
            _can_be_traversed_flyer = value;
        }
    }

    private int _mv_granted_infantry;
    public int MvGrantedInfantry
    {
        get
        {
            return _mv_granted_infantry;
        }
        set
        {
            _mv_granted_infantry = value;
        }
    }
    private int _mv_granted_armor;
    public int MvGrantedArmor
    {
        get
        {
            return _mv_granted_armor;
        }
        set
        {
            _mv_granted_armor = value;
        }
    }
    private int _mv_granted_horse;
    public int MvGrantedHorse
    {
        get
        {
            return _mv_granted_horse;
        }
        set
        {
            _mv_granted_horse = value;
        }
    }
    private int _mv_granted_flyer;
    public int MvGrantedFlyer
    {
        get
        {
            return _mv_granted_flyer;
        }
        set
        {
            _mv_granted_flyer = value;
        }
    }
    private int _hp_effects_infantry;
    public int HpEffectsInfantry
    {
        get 
        {
            return _hp_effects_infantry;
        }
        set
        {
            _hp_effects_infantry = value;
        }
    }
    private int _hp_effects_armor;
    public int HpEffectsArmor
    {
        get 
        {
            return _hp_effects_armor;
        }
        set
        {
            _hp_effects_armor = value;
        }
    }
    private int _hp_effects_horse;
    public int HpEffectsHorse
    {
        get 
        {
            return _hp_effects_horse;
        }
        set
        {
            _hp_effects_horse = value;
        }
    }
    private int _hp_effects_flyer;
    public int HpEffectsFlyer
    {
        get 
        {
            return _hp_effects_flyer;
        }
        set
        {
            _hp_effects_flyer = value;
        }
    }
}