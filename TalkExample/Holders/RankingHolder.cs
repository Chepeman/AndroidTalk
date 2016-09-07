using System;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace TalkExample
{
	public class RankingHolder : RecyclerView.ViewHolder
	{
		public ImageView IVIcon { get; private set; }
		public TextView TVLanguageName { get; private set; }
		public TextView TVDeveloperCompany { get; private set; }

		public RankingHolder(View itemView) : base (itemView)
		{
			IVIcon = itemView.FindViewById<ImageView>(Resource.Id.iv_icon);
			TVLanguageName = itemView.FindViewById<TextView>(Resource.Id.tv_languagename);
			TVDeveloperCompany = itemView.FindViewById<TextView>(Resource.Id.tv_developer);
		}
	}
}

