namespace nswag_ignored_properties
{
    public class Dog : Animal
    {
        /// <summary>
        /// it's a property of Dog
        /// </summary>
        public string Bar { get; set; }

        /// <summary>
        /// Should be ignored, it's an overriden property inherited from Animal
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        [NSwag.Annotations.OpenApiIgnore]
        [NJsonSchema.Annotations.JsonSchemaIgnore]
        public override int Foo { get; set; }
    }
}
