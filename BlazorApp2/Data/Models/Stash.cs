namespace BlazorApp2.Data.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Item
    {
        public bool verified { get; set; }
        public int w { get; set; }
        public int h { get; set; }
        public string icon { get; set; }
        public int stackSize { get; set; }
        public int maxStackSize { get; set; }
        public string league { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string typeLine { get; set; }
        public string baseType { get; set; }
        public bool identified { get; set; }
        public int ilvl { get; set; }
        public List<Property> properties { get; set; }
        public List<string> explicitMods { get; set; }
        public string rewardText { get; set; }
        public List<string> flavourText { get; set; }
        public string cardText { get; set; }
        public int frameType { get; set; }
        public string artFilename { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string inventoryId { get; set; }
    }

    public class Metadata
    {
        public string colour { get; set; }
    }

    public class Property
    {
        public string name { get; set; }
        public List<List<object>> values { get; set; }
        public int displayMode { get; set; }
        public int type { get; set; }
    }

    public class Root
    {
        public Stash stash { get; set; }
    }

    public class Stash
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int index { get; set; }
        public Metadata metadata { get; set; }
        public List<Item> items { get; set; }
    }
}
