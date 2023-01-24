﻿namespace UzTexGroup.Domain.Entities;
public class News
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public ICollection<NewImages>? NewImages { get; set; }

}
