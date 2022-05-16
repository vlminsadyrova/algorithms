using System;
using System.Collections.Generic;
using System.Linq;

namespace palletsAdaptation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alias = new[] { "instanceable", "sortable", "liquid", "household_chemicals" };



            Dictionary<string, int> Priorities = new Dictionary<string, int>
            {
                { "household_chemicals", 3},
                { "liquid", 25}

            };

            TagModel[] tagModel = new[] {
                new TagModel (
                TagId: 1,
                TagType: 2,
                TagAlias: "sortable",
                TagName: "сорт"
                ),
                new TagModel (
                TagId: 2,
                TagType: 2,
                TagAlias: "liquid",
                TagName: "вода"
                ),
                new TagModel (
                TagId: 3,
                TagType: 2,
                TagAlias: "household_chemicals",
                TagName: "химия"
                )
            };

            TagModel[] tagModel2 = new[] {
                new TagModel (
                TagId: 2,
                TagType: 2,
                TagAlias: "liquid",
                TagName: "вода"
                ),
                new TagModel (
                TagId: 3,
                TagType: 2,
                TagAlias: "household_chemicals",
                TagName: "химия"
                )
            };

            var tagIds = tagModel2.Select(tag => tag.TagId).ToArray();

            foreach (var tag in tagIds)
            {
                var t = tagModel.Where(t => t.TagId != tag).ToArray();

                tagModel = t;
            }

            var ttt = tagModel;

            var n = Priorities.OrderBy(v => v.Value).Select(k => k.Key).Concat(alias).Distinct().ToArray();
            var tagPriorities = new TagPrioritiesAliasesModel[] { };
            foreach (var a in n)
            {
                var tag = tagModel.Where(tag => tag.TagAlias == a).ToArray();
                for (int i = 0; i < n.Length; i++)
                {
                    tagPriorities[i] = new TagPrioritiesAliasesModel(TagAlias: a);
                };
            }



            //string[] v = n.Select(k => k.Key).Concat(alias).Distinct().ToArray();

            Console.WriteLine(n.Length);
        }
    }
    public sealed record TagModel(
         long TagId,
         int TagType,
         string TagAlias,
         string TagName
        );

    public sealed record TagPrioritiesAliasesModel(
         string TagAlias);

    public sealed record TaskStatusModel
    (
        long TaskId,
        long CellId,
        long PalletId,
        long TransferPalletId,
        long SourceWarehouseId,
        long DestinationWarehouseId,
        string HostName,
        bool IsMonoPallet,
        bool IsUnmarkedPallet,
        DateTimeOffset CreatedOn,
        long? InitialTaskId
    );
}
