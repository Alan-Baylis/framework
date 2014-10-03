//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------

// NOTE changed to use lazy initialization and default size of Lists where is performance critical
// Generated from: osmformat.proto
namespace Mercraft.Maps.Osm.Formats.Pbf
{
  /// <summary>
  /// 
  /// </summary>
  [global::ProtoBuf.ProtoContract(Name=@"HeaderBlock")]
  public partial class HeaderBlock : global::ProtoBuf.IExtensible
  {
    /// <summary>
    /// 
    /// </summary>
    public HeaderBlock() {}
    

    private HeaderBBox _bbox = null;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bbox", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public HeaderBBox bbox
    {
      get { return _bbox; }
      set { _bbox = value; }
    }
    private global::System.Collections.Generic.List<string> _required_features;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(4, Name=@"required_features", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> required_features
    {
        get
        {
            if (_required_features == null)
                _required_features = new global::System.Collections.Generic.List<string>();
            return _required_features;
        }
    }
  
    private global::System.Collections.Generic.List<string> _optional_features;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(5, Name=@"optional_features", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> optional_features
    {
        get
        {
            if (_optional_features == null)
                _optional_features = new global::System.Collections.Generic.List<string>();
            return _optional_features;
        }
    }
  

    private string _writingprogram = "";
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"writingprogram", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string writingprogram
    {
      get { return _writingprogram; }
      set { _writingprogram = value; }
    }

    private string _source = "";
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"source", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string source
    {
      get { return _source; }
      set { _source = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  /// <summary>
  /// 
  /// </summary>
  [global::ProtoBuf.ProtoContract(Name=@"HeaderBBox")]
  public partial class HeaderBBox : global::ProtoBuf.IExtensible
  {
    /// <summary>
    /// 
    /// </summary>
    public HeaderBBox() {}
    
    private long _left;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"left", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public long left
    {
      get { return _left; }
      set { _left = value; }
    }
    private long _right;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"right", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public long right
    {
      get { return _right; }
      set { _right = value; }
    }
    private long _top;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"top", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public long top
    {
      get { return _top; }
      set { _top = value; }
    }
    private long _bottom;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"bottom", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public long bottom
    {
      get { return _bottom; }
      set { _bottom = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  /// <summary>
  /// 
  /// </summary>
  [global::ProtoBuf.ProtoContract(Name=@"PrimitiveBlock")]
  public partial class PrimitiveBlock : global::ProtoBuf.IExtensible
  {
    /// <summary>
    /// 
    /// </summary>
    public PrimitiveBlock() {}
    
    private StringTable _stringtable;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"stringtable", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public StringTable stringtable
    {
      get { return _stringtable; }
      set { _stringtable = value; }
    }
    private global::System.Collections.Generic.List<PrimitiveGroup> _primitivegroup;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(2, Name=@"primitivegroup", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PrimitiveGroup> primitivegroup
    {
        get
        {
            if (_primitivegroup == null)
                _primitivegroup = new global::System.Collections.Generic.List<PrimitiveGroup>(2);
            return _primitivegroup;
        }
    }
  

    private int _granularity = (int)100;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"granularity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)100)]
    public int granularity
    {
      get { return _granularity; }
      set { _granularity = value; }
    }

    private long _lat_offset = (long)0;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"lat_offset", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((long)0)]
    public long lat_offset
    {
      get { return _lat_offset; }
      set { _lat_offset = value; }
    }

    private long _lon_offset = (long)0;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"lon_offset", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((long)0)]
    public long lon_offset
    {
      get { return _lon_offset; }
      set { _lon_offset = value; }
    }

    private int _date_granularity = (int)1000;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"date_granularity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)1000)]
    public int date_granularity
    {
      get { return _date_granularity; }
      set { _date_granularity = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  /// <summary>
  /// 
  /// </summary>
  [global::ProtoBuf.ProtoContract(Name=@"PrimitiveGroup")]
  public partial class PrimitiveGroup : global::ProtoBuf.IExtensible
  {
    /// <summary>
    /// 
    /// </summary>
    public PrimitiveGroup() {}

    public bool IsNodeListEmpty
    {
        get
        {
            return _nodes == null || _nodes.Count == 0;
        }
    }
    private global::System.Collections.Generic.List<Node> _nodes;
    [global::ProtoBuf.ProtoMember(1, Name=@"nodes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Node> nodes
    {
        get
        {
            return _nodes;
        }
      set { _nodes = value; }
    }
  

    private DenseNodes _dense = null;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"dense", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public DenseNodes dense
    {
      get { return _dense; }
      set { _dense = value; }
    }

    public bool IsWayListEmpty
    {
        get
        {
            return _ways == null || _ways.Count == 0;
        }
    }
    private global::System.Collections.Generic.List<Way> _ways;
    [global::ProtoBuf.ProtoMember(3, Name=@"ways", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Way> ways
    {
        get
        {
            if (_ways == null)
                _ways = new global::System.Collections.Generic.List<Way>(512);
            return _ways;
        }
    }

    public bool IsRelationListEmpty
    {
        get
        {
            return _relations == null || _relations.Count == 0;
        }
    }
      private global::System.Collections.Generic.List<Relation> _relations;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(4, Name=@"relations", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Relation> relations
    {
        get
        {
            if (_relations == null)
                _relations = new global::System.Collections.Generic.List<Relation>(32);
            return _relations;
        }
    }

      private global::System.Collections.Generic.List<ChangeSet> _changesets;// = new global::System.Collections.Generic.List<ChangeSet>();
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(5, Name=@"changesets", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ChangeSet> changesets
    {
        get
        {
            if (_changesets == null)
                _changesets = new global::System.Collections.Generic.List<ChangeSet>();
            return _changesets;
        }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  /// <summary>
  /// 
  /// </summary>
  [global::ProtoBuf.ProtoContract(Name=@"StringTable")]
  public partial class StringTable : global::ProtoBuf.IExtensible
  {
    /// <summary>
    /// 
    /// </summary>
    public StringTable() {}
    
    private global::System.Collections.Generic.List<byte[]> _s;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(1, Name=@"s", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<byte[]> s
    {
        get
        {
            if (_s == null)
                _s = new global::System.Collections.Generic.List<byte[]>(32);
            return _s;
        }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  /// <summary>
  /// 
  /// </summary>
  [global::ProtoBuf.ProtoContract(Name=@"Info")]
  public partial class Info : global::ProtoBuf.IExtensible
  {
    /// <summary>
    /// 
    /// </summary>
    public Info() {}
    

    private int _version = (int)-1;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int version
    {
      get { return _version; }
      set { _version = value; }
    }

    private int _timestamp = default(int);
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"timestamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int timestamp
    {
      get { return _timestamp; }
      set { _timestamp = value; }
    }

    private long _changeset = default(long);
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"changeset", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long changeset
    {
      get { return _changeset; }
      set { _changeset = value; }
    }

    private int _uid = default(int);
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int uid
    {
      get { return _uid; }
      set { _uid = value; }
    }

    private int _user_sid = default(int);
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"user_sid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int user_sid
    {
      get { return _user_sid; }
      set { _user_sid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  /// <summary>
  /// 
  /// </summary>
  [global::ProtoBuf.ProtoContract(Name=@"DenseInfo")]
  public partial class DenseInfo : global::ProtoBuf.IExtensible
  {
    /// <summary>
    /// 
    /// </summary>
    public DenseInfo() {}
    
    private global::System.Collections.Generic.List<int> _version;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(1, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<int> version
    {
        get
        {
            if (_version == null)
                _version = new global::System.Collections.Generic.List<int>();
            return _version;
        }
    }
  
    private global::System.Collections.Generic.List<long> _timestamp;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(2, Name=@"timestamp", DataFormat = global::ProtoBuf.DataFormat.ZigZag, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<long> timestamp
    {
        get
        {
            if (_timestamp == null)
                _timestamp = new global::System.Collections.Generic.List<long>();
            return _timestamp;
        }
    }
  
    private global::System.Collections.Generic.List<long> _changeset;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(3, Name=@"changeset", DataFormat = global::ProtoBuf.DataFormat.ZigZag, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<long> changeset
    {
        get
        {
            if (_changeset == null)
                _changeset = new global::System.Collections.Generic.List<long>();
            return _changeset;
        }
    }
  
    private global::System.Collections.Generic.List<int> _uid;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(4, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.ZigZag, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<int> uid
    {
        get
        {
            if(_uid == null)
                _uid = new global::System.Collections.Generic.List<int>();
            return _uid;
        }
    }
  
    private global::System.Collections.Generic.List<int> _user_sid;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(5, Name=@"user_sid", DataFormat = global::ProtoBuf.DataFormat.ZigZag, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<int> user_sid
    {
        get
        {
            if (_user_sid == null)
                _user_sid = new global::System.Collections.Generic.List<int>();
            return _user_sid;
        }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  /// <summary>
  /// 
  /// </summary>
  [global::ProtoBuf.ProtoContract(Name=@"ChangeSet")]
  public partial class ChangeSet : global::ProtoBuf.IExtensible
  {
    /// <summary>
    /// 
    /// </summary>
    public ChangeSet() {}
    
    private long _id;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long id
    {
      get { return _id; }
      set { _id = value; }
    }
    private global::System.Collections.Generic.List<uint> _keys;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(2, Name=@"keys", DataFormat = global::ProtoBuf.DataFormat.TwosComplement, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<uint> keys
    {
        get
        {
            if (_keys == null)
                _keys = new global::System.Collections.Generic.List<uint>();
            return _keys;
        }
    }
  
    private global::System.Collections.Generic.List<uint> _vals;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(3, Name=@"vals", DataFormat = global::ProtoBuf.DataFormat.TwosComplement, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<uint> vals
    {
        get
        {
            if (_vals == null)
                _vals = new global::System.Collections.Generic.List<uint>();
            return _vals;
        }
    }
  

    private Info _info = null;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Info info
    {
      get { return _info; }
      set { _info = value; }
    }
    private long _created_at;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"created_at", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long created_at
    {
      get { return _created_at; }
      set { _created_at = value; }
    }

    private long _closetime_delta = default(long);
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"closetime_delta", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long closetime_delta
    {
      get { return _closetime_delta; }
      set { _closetime_delta = value; }
    }
    private bool _open;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"open", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool open
    {
      get { return _open; }
      set { _open = value; }
    }

    private HeaderBBox _bbox = null;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"bbox", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public HeaderBBox bbox
    {
      get { return _bbox; }
      set { _bbox = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  /// <summary>
  /// 
  /// </summary>
  [global::ProtoBuf.ProtoContract(Name=@"Node")]
  public struct Node : global::ProtoBuf.IExtensible
  {
      public void Initialize()
      {
          _keys = new global::System.Collections.Generic.List<uint>(1);
          _vals = new global::System.Collections.Generic.List<uint>(1);
      }

    private long _id;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public long id
    {
      get { return _id; }
      set { _id = value; }
    }
    private global::System.Collections.Generic.List<uint> _keys;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(2, Name=@"keys", DataFormat = global::ProtoBuf.DataFormat.TwosComplement, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<uint> keys
    {
      get { return _keys; }
    }

    private global::System.Collections.Generic.List<uint> _vals;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(3, Name=@"vals", DataFormat = global::ProtoBuf.DataFormat.TwosComplement, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<uint> vals
    {
        get
        {
            return _vals;
        }
    }
  
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Info info
    {
      set {}
    }
    private long _lat;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"lat", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public long lat
    {
      get { return _lat; }
      set { _lat = value; }
    }
    private long _lon;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"lon", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public long lon
    {
      get { return _lon; }
      set { _lon = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  /// <summary>
  /// 
  /// </summary>
  [global::ProtoBuf.ProtoContract(Name=@"DenseNodes")]
  public partial class DenseNodes : global::ProtoBuf.IExtensible
  {
    /// <summary>
    /// 
    /// </summary>
    public DenseNodes() {}
    
    private global::System.Collections.Generic.List<long> _id;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(1, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.ZigZag, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<long> id
    {
        get
        {
            if (_id == null)
                _id = new global::System.Collections.Generic.List<long>(1024);
            return _id;
        }
    }
  

    private DenseInfo _denseinfo = null;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"denseinfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public DenseInfo denseinfo
    {
      get { return _denseinfo; }
      set { _denseinfo = value; }
    }

      private global::System.Collections.Generic.List<long> _lat;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(8, Name=@"lat", DataFormat = global::ProtoBuf.DataFormat.ZigZag, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<long> lat
    {
        get
        {
            if (_lat == null)
                _lat = new global::System.Collections.Generic.List<long>(_id.Count);
            return _lat;
        }
    }
  
    private global::System.Collections.Generic.List<long> _lon;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(9, Name=@"lon", DataFormat = global::ProtoBuf.DataFormat.ZigZag, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<long> lon
    {
        get
        {
            if (_lon == null)
                _lon = new global::System.Collections.Generic.List<long>(_id.Count);
            return _lon;
        }
    }
  
    private global::System.Collections.Generic.List<int> _keys_vals;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(10, Name=@"keys_vals", DataFormat = global::ProtoBuf.DataFormat.TwosComplement, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<int> keys_vals
    {
        get
        {
            if (_keys_vals == null)
                _keys_vals = new global::System.Collections.Generic.List<int>(512);
            return _keys_vals;
        }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  /// <summary>
  /// 
  /// </summary>
  [global::ProtoBuf.ProtoContract(Name=@"Way")]
  public partial class Way : global::ProtoBuf.IExtensible
  {
   
    private long _id;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long id
    {
      get { return _id; }
      set { _id = value; }
    }
    private global::System.Collections.Generic.List<uint> _keys;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(2, Name=@"keys", DataFormat = global::ProtoBuf.DataFormat.TwosComplement, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<uint> keys
    {
        get
        {
            if (_keys == null)
                _keys = new global::System.Collections.Generic.List<uint>(16);
            return _keys;
        }
    }
  
    private global::System.Collections.Generic.List<uint> _vals;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(3, Name=@"vals", DataFormat = global::ProtoBuf.DataFormat.TwosComplement, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<uint> vals
    {
        get
        {
            if (_vals == null)
                _vals = new global::System.Collections.Generic.List<uint>(_keys.Count);
            return _vals;
        }
    }


      private Info _info;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Info info
    {
      get { return _info; }
      set { _info = value; }
    }
    private global::System.Collections.Generic.List<long> _refs;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(8, Name=@"refs", DataFormat = global::ProtoBuf.DataFormat.ZigZag, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<long> refs
    {
        get
        {
            if (_refs == null)
                _refs = new global::System.Collections.Generic.List<long>();
            return _refs;
        }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  /// <summary>
  /// 
  /// </summary>
  [global::ProtoBuf.ProtoContract(Name=@"Relation")]
  public partial class Relation : global::ProtoBuf.IExtensible
  {
    /// <summary>
    /// 
    /// </summary>
    public Relation() {}
    
    private long _id;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long id
    {
      get { return _id; }
      set { _id = value; }
    }
    private global::System.Collections.Generic.List<uint> _keys;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(2, Name=@"keys", DataFormat = global::ProtoBuf.DataFormat.TwosComplement, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<uint> keys
    {
        get
        {
            if (_keys == null)
                _keys = new global::System.Collections.Generic.List<uint>();
            return _keys;
        }
    }
  
    private global::System.Collections.Generic.List<uint> _vals;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(3, Name=@"vals", DataFormat = global::ProtoBuf.DataFormat.TwosComplement, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<uint> vals
    {
        get
        {
            if (_vals == null)
                _vals = new global::System.Collections.Generic.List<uint>();
            return _vals;
        }
    }
  

    private Info _info = null;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Info info
    {
      get { return _info; }
      set { _info = value; }
    }
    private global::System.Collections.Generic.List<int> _roles_sid;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(8, Name=@"roles_sid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<int> roles_sid
    {
        get
        {
            if (_roles_sid == null)
                _roles_sid = new global::System.Collections.Generic.List<int>();
            return _roles_sid;
        }
    }
  
    private global::System.Collections.Generic.List<long> _memids;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(9, Name=@"memids", DataFormat = global::ProtoBuf.DataFormat.ZigZag, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<long> memids
    {
        get
        {
            if (_memids == null)
                _memids = new global::System.Collections.Generic.List<long>();
            return _memids;
        }
    }
  
    private global::System.Collections.Generic.List<Relation.MemberType> _types;
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoMember(10, Name=@"types", DataFormat = global::ProtoBuf.DataFormat.TwosComplement, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<Relation.MemberType> types
    {
        get
        {
            if (_types == null)
                _types = new global::System.Collections.Generic.List<Relation.MemberType>();
            return _types;
        }
    }
  
    /// <summary>
    /// 
    /// </summary>
    [global::ProtoBuf.ProtoContract(Name=@"MemberType")]
    public enum MemberType
    {
            
      /// <summary>
      /// 
      /// </summary>
      [global::ProtoBuf.ProtoEnum(Name=@"NODE", Value=0)]
      NODE = 0,
            
      /// <summary>
      /// 
      /// </summary>
      [global::ProtoBuf.ProtoEnum(Name=@"WAY", Value=1)]
      WAY = 1,
            
      /// <summary>
      /// 
      /// </summary>
      [global::ProtoBuf.ProtoEnum(Name=@"RELATION", Value=2)]
      RELATION = 2
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
