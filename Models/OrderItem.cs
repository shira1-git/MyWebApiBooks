using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Entities;

public partial class OrderItem
{
    public int OrderItemId { get; set; }

    public int? ProductId { get; set; }

    public int? OrderId { get; set; }

    public int? Quentity { get; set; }
<<<<<<< HEAD
    //[JsonIgnore]
    public virtual Order? Order { get; set; }
   // [JsonIgnore]
=======
    [JsonIgnore]
    public virtual Order? Order { get; set; }
    [JsonIgnore]
>>>>>>> a3847faecf94dcd15fa9e2a2541b09d81fefac35
    public virtual Product? Product { get; set; }
}
