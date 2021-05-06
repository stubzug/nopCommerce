using FluentMigrator;
using Nop.Core.Domain.Configuration;
using Nop.Core.Infrastructure;
using Nop.Data;
using Nop.Data.Migrations;

namespace Nop.Web.Framework.Migrations.UpgradeTo4403
{
    [NopMigration("2021-05-06 00:00:00", "4.40.3", UpdateMigrationType.Settings)]
    [SkipMigrationOnInstall]
    public class SettingMigration : MigrationBase
    {
        /// <summary>Collect the UP migration expressions</summary>
        public override void Up()
        {
            if (!DataSettingsManager.IsDatabaseInstalled())
                return;

            //do not use DI, because it produces exception on the installation process
            var settingRepository = EngineContext.Current.Resolve<IRepository<Setting>>();

            //#5650
            settingRepository
                .DeleteAsync(setting => setting.Name == "catalogsettings.searchpagepricerangefiltering" ||
                    setting.Name == "catalogsettings.searchpagepricefrom" ||
                    setting.Name == "catalogsettings.searchpagepriceto" ||
                    setting.Name == "catalogsettings.searchpagemanuallypricerange")
                .Wait();
        }

        public override void Down()
        {
            //add the downgrade logic if necessary 
        }
    }
}