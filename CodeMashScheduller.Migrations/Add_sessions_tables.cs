using System.Data;
using Migrator.Framework;
using FKC = Migrator.Framework.ForeignKeyConstraint;

namespace CodeMashScheduller.Migrations
{
    [Migration(20091123215028)]
    public class m_20091123215028_Add_sessions_tables : Migration
    {
        public override void Up()
        {
            DatabaseUP
        }

        public override void Down()
        {
            DatabaseDOWN
        }
    }
}
