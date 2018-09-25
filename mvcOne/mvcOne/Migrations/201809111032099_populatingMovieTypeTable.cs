namespace mvcOne.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatingMovieTypeTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO MovieTypes(Id,Name) VALUES (1,'Comedy')
                  INSERT INTO MovieTypes(Id,Name) VALUES (2,'Action')
                  INSERT INTO MovieTypes(Id,Name) VALUES (3,'Drama')
                  INSERT INTO MovieTypes(Id,Name) VALUES (4,'Thrill')
                  INSERT INTO MovieTypes(Id,Name) VALUES (5,'Horor')");
        }
        
        public override void Down()
        {
        }
    }
}
