namespace BlazorLabbv3.Components.Pages
{
	public partial class ExistingUsers
	{
		public List<User>? Users { get; set; }
		private bool _isShowing5Users = true;
		private bool _isSortedById = false;
		private bool _isSortedByName = true;
		private bool _isSortedByUsername = false;
		private string searchQuery = "";
		public List<User>? FilteredUsers => Users?.Where(u => u.name.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)).ToList();

		protected override async Task OnInitializedAsync()
		{
			await Task.Delay(250);

			// getting users from api
			UserDataFromApi userData = new UserDataFromApi();

			// getting my own created users
			//UserDataFromStatic userData = new UserDataFromStatic();


			Users = await userData.GetUsersAsync();

			//sorting by name and filtering 5 users
			Users = Users?.Show5Users().SortUsersByName();


		}


		private void ShowMoreOrLessUsers()
		{
			if (!_isShowing5Users)
			{
				Users = Users?.Take(5).ToList();
			}
			else
			{
				Users = Users = Users?.Take(10).ToList();
			}
			_isShowing5Users = !_isShowing5Users;
		}

		private void SortById()
		{
			if (!_isSortedById)
			{
				Users = Users?.OrderBy(user => user.id).ToList();
			}
			else
			{
				Users = Users?.OrderByDescending(user => user.id).ToList();
			}
			_isSortedById = !_isSortedById;
		}

		private void SortByName()
		{
			if (!_isSortedByName)
			{
				Users = Users?.OrderBy(user => user.name).ToList();
			}
			else
			{
				Users = Users?.OrderByDescending(user => user.name).ToList();
			}
			_isSortedByName = !_isSortedByName;
		}

		private void SortByUsername()
		{
			if (!_isSortedByUsername)
			{
				Users = Users?.OrderBy(user => user.username).ToList();
			}
			else
			{
				Users = Users?.OrderByDescending(user => user.username).ToList();
			}
			_isSortedByUsername = !_isSortedByUsername;
		}
	}
}