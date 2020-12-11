namespace ScrumShot_CreateStory
{
    class Story
    {
        private int storyID;
        private int projectID;
        private string storydescription;
        private string status;

        public int StoryID { get => storyID; set => storyID = value; }
        public int ProjectID { get => projectID; set => projectID = value; }
        public string Storydescription { get => storydescription; set => storydescription = value; }
        public string Status { get => status; set => status = value; }

        public Story(int storyID, int projectID, string storydescription, string status)
        {
            StoryID = storyID;
            ProjectID = projectID;
            Storydescription = storydescription;
            Status = status;
        }

        public Story(string storydescription)
        {
            Storydescription = storydescription;
            status = "none";
        }
    }

    enum status
    {
        none,
        toDo,
        InProgress,
        toVerify,
        Done,

    }
}