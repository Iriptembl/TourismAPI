using System;
using System.Collections.Generic;

namespace TourismAPI.Models;

public partial class Review
{
    public int Id { get; set; }

    public int PlaceId { get; set; }

    public int TouristId { get; set; }

    public int Rating { get; set; }

    public string Title { get; set; }

    public string Text { get; set; }

    public virtual Place Place { get; set; }

    public virtual Tourist Tourist { get; set; }
}
