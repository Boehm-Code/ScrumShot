using System.Collections.Generic;

namespace Scrum_Shot
{
    public class ProductBacklog
    {
        List<ProductBacklogPoint> backlogPoints;

    }
    public class ProductBacklogPoint
    {
        string description;
        int storyPoints;
        bool inProgress;
        bool done;
        User editedBy;



        public string Description { get; set; }
        public int StoryPoints { get; set; }
        public bool InProgress { get; set; }
        public bool Done { get; set; }
        public User EditedBy { get; set; }
    }
}