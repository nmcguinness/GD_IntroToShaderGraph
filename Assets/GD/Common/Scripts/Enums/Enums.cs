namespace GD.Enums
{
    /// <summary>
    /// Demos using a custom enum
    /// </summary>
    /// <see cref="GD.Selection.GameObjectRayProvider"/>
    public enum ToggleType : sbyte
    {
        On, Off
    }

    /// <summary>
    /// Used in a ScriptableObject to indicate the type of the item about which the SO is storing information
    /// </summary>
    /// <see cref="Objects.BaseObjectData"/>
    public enum ItemType : sbyte
    {
        Building, Equipment, Food, Medicine, NPC, Player, Story, Weapon
    }

    /// <summary>
    /// Defines the core attributes that an object can modify in a player.
    /// For example, a health pickup will modify speed, strength, or stamina.
    /// </summary>
    /// <see cref="Objects.ConsumableObjectData"/>
    public enum AttributeType : sbyte
    {
        Agility, Intelligence, Knowledge, Mana, Sight, Speed, Strength, Stamina
    }

    /// <summary>
    /// Defines the attack type of a NPC
    /// </summary>
    /// <see cref="GD.Objects.PlaceableObjectData"/>
    public enum AttackType : sbyte
    {
        Melee, Ranged
    }

    /// <summary>
    /// Defines the type of unit that an NPC will attack
    /// </summary>
    /// <see cref="GD.Objects.PlaceableObjectData"/>
    public enum AttackTargetType : sbyte
    {
        Any, Building, None, Unit, Vehicle
    }

    /// <summary>
    /// Used to indicate priority (e.g. completion of objectives)
    /// </summary>
    /// <see cref="GD.ScriptableTypes.RuntimeGameObjectiveList"/>
    public enum PriorityType : sbyte
    {
        //assigning explicit values here allows us to sort whatever entity (e.g. GameObjective) use this type
        Low = 0, Normal = 1, High = 2, Critical = 3
    }

    /// <summary>
    /// Used to specify if an onscreen object (e.g. a waypoint) is always shown
    /// </summary>
    /// <see cref="GD.ScriptableTypes.RuntimeGameObjectiveList"/>
    public enum VisibilityStrategyType : sbyte
    {
        ShowAlways, ShowWithin, ShowNever
    }
}