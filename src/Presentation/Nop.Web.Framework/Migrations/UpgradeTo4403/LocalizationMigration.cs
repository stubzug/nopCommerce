using System.Collections.Generic;
using FluentMigrator;
using Nop.Core.Infrastructure;
using Nop.Data;
using Nop.Data.Migrations;
using Nop.Services.Localization;

namespace Nop.Web.Framework.Migrations.UpgradeTo4403
{
    [NopMigration("2021-05-06 00:00:00", "4.40.3", UpdateMigrationType.Localization)]
    [SkipMigrationOnInstall]
    public class LocalizationMigration : MigrationBase
    {
        /// <summary>Collect the UP migration expressions</summary>
        public override void Up()
        {
            if (!DataSettingsManager.IsDatabaseInstalled())
                return;

            //do not use DI, because it produces exception on the installation process
            var localizationService = EngineContext.Current.Resolve<ILocalizationService>();

            //use localizationService to add, update and delete localization resources
            localizationService.DeleteLocaleResourcesAsync(new List<string>
            {
                //#5650
                "Admin.Configuration.Settings.Catalog.SearchPagePriceRangeFiltering",
                "Admin.Configuration.Settings.Catalog.SearchPagePriceFrom",
                "Admin.Configuration.Settings.Catalog.SearchPagePriceTo",
                "Admin.Configuration.Settings.Catalog.SearchPageManuallyPriceRange"
            });

            localizationService.AddLocaleResourceAsync(new Dictionary<string, string>
            {
                //#5650
                ["Search.PriceRange"] = "Price range",
                ["Search.PriceRange.From"] = "From",
                ["Search.PriceRange.To"] = "to"
            }).Wait();
        }

        /// <summary>Collects the DOWN migration expressions</summary>
        public override void Down()
        {
            //add the downgrade logic if necessary 
        }
    }
}
