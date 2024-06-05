using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm;

namespace Observable_Validator
{
    public partial class PersonViewModel : ObservableValidator
    {
	    private int age;
	    private int minAge;

		[ObservableProperty]
	    [NotifyDataErrorInfo]
	    [Required]
		[MinLength(3)]
	    private string? name;

	    [ObservableProperty]
		[NotifyDataErrorInfo]
		[EmailAddress]
	    private string? email;

		[Range(0, 100)]
		[GreaterOrEqualThan(nameof(MinAge))]
		public int Age
		{
			get => this.age;
			set => SetProperty(ref this.age, value, true);
		}
		
		[Range(0, 100)]
		public int MinAge
		{
			get => this.minAge;
			set
			{
				SetProperty(ref this.minAge, value, true);
				ValidateProperty(this.Age, nameof(this.Age));
			}
		}

	}
}
