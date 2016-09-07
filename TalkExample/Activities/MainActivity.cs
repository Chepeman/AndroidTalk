using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;
using System.Collections.Generic;
using Android.Support.V7.Widget.Helper;

namespace TalkExample
{
	[Activity(Label = "Language Ranking - Talk Example", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		RecyclerView RecyclerView;
		RankingAdapter Adapter;
		List<Language> LanguageList;
		LinearLayoutManager LayoutManager;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
			RecyclerView = FindViewById<RecyclerView>(Resource.Id.ranking_recyclerlist);

			LanguageList = new List<Language>();
			LoadLanguages();

			LayoutManager = new LinearLayoutManager(this);
			LayoutManager.Orientation = LinearLayoutManager.Vertical;
			RecyclerView.SetLayoutManager(LayoutManager);
			Adapter = new RankingAdapter(LanguageList);
			RecyclerView.SetAdapter(Adapter);

			ItemTouchCallback callback = new ItemTouchCallback(Adapter);
			ItemTouchHelper touchHelper = new ItemTouchHelper(callback);
			touchHelper.AttachToRecyclerView(RecyclerView);
		}

		void LoadLanguages()
		{
			LanguageList.Add(new Language("C#", "Microsoft", "csharp_icon"));
			LanguageList.Add(new Language("Java", "Sun Systems", "java_icon"));
			LanguageList.Add(new Language("HTML", "W3C && WHATWG", "html_icon"));
			LanguageList.Add(new Language("C++", "Bjarne Stroustrup", "cplus_icon"));
			LanguageList.Add(new Language("JavaScript", "Various Co.", "js_icon"));
		}


	}
}


