namespace BindingFailureListBugMinimal
{
    internal class ViewModel
    {
        public List<ExampleModel> Examples { get; set; } = [new() { Name = "test1" }, new() { Name = "test2" }];
    }
}
