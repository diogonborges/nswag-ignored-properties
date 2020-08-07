namespace nswag_ignored_properties
{
    public class Animal
    {
        /// <summary>
        /// Should be ignored, it's an Animal property
        /// </summary>
        [System.Text.Json.Serialization.JsonIgnore]
        public int Baz { get; set; }

        /// <summary>
        /// It's a virtual property of Animal
        /// </summary>
        public virtual int Foo { get; set; }
    }
}