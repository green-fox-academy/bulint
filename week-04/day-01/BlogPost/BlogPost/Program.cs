using System;

namespace BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var LoremIpsum = new BlogPost();
            LoremIpsum.AuthorName = "John Doe";
            LoremIpsum.Title = "Lorem Ipsum";
            LoremIpsum.PublicationDate = "2000.05.04.";
            LoremIpsum.Text = "Lorem ipsum dolor sit amet.";

            var WaitButWhy = new BlogPost();
            WaitButWhy.AuthorName = "Tim Urban";
            WaitButWhy.Title = "Wait but why";
            WaitButWhy.PublicationDate = "2010.10.10.";
            WaitButWhy.Text = "A popular long-form, stick-figure-illustrated blog about almost everything.";

            var OneEngineerIsTryingtoGetIBMtoReckonWithTrump = new BlogPost();
            OneEngineerIsTryingtoGetIBMtoReckonWithTrump.AuthorName = "William Turton";
            OneEngineerIsTryingtoGetIBMtoReckonWithTrump.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            OneEngineerIsTryingtoGetIBMtoReckonWithTrump.PublicationDate = "2017.03.28.";
            OneEngineerIsTryingtoGetIBMtoReckonWithTrump.Text = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.";
        }
    }
}

