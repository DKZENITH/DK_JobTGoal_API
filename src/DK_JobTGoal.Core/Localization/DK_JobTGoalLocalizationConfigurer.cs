using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace DK_JobTGoal.Localization
{
    public static class DK_JobTGoalLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(DK_JobTGoalConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(DK_JobTGoalLocalizationConfigurer).GetAssembly(),
                        "DK_JobTGoal.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
