using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace pet_hotel
{
    public enum PetBreedType 
    {
        Shepherd,
        Poodle,
        Beagle,
        Bulldog,
        Terrier,
        Boxer,
        Labrador,
        Retriever

    }
    
    public enum PetColorType 
    {
        White, 
        Black, 
        Golden, 
        Tricolor, 
        Spotted
    }
    
    public class Pet 
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetBreedType PetBreed { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetColorType PetColor { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CheckedInAt { get; set; }

        [ForeignKey("PetOwner")]
        public int PetOwnerId { get; set; }

        public PetOwner PetOwner { get; set; }
    }
}
