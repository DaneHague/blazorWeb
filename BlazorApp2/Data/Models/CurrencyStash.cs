namespace BlazorApp2.Data.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class CurrencyItem
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
        public List<string> explicitMods { get; set; }
        public int ilvl { get; set; }
        public string rewardText { get; set; }
        public string cardText { get; set; }
        public int frameType { get; set; }
        public string artFilename { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string inventoryId { get; set; }
    }

    public class CurrencyMetadata
    {
        public string colour { get; set; }
    }

    public class CurrencyProperty
    {
        public string name { get; set; }
        public List<List<object>> values { get; set; }
        public int displayMode { get; set; }
        public int type { get; set; }
    }

    public class CurrencyRoot
    {
        public CurrencyStash stash { get; set; }
    }

    public class CurrencyStash
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int index { get; set; }
        public Metadata metadata { get; set; }
        public List<CurrencyItem> items { get; set; }
    }


}
