using System;
using Android.Support.V7.Widget;
using Android.Views;
using System.Collections.Generic;
using Android.Content.Res;
using Android.Graphics.Drawables;

namespace TalkExample
{
	public class RankingAdapter : RecyclerView.Adapter, IItemTouchHelper
	{
		public List<Language> LanguageList;
		public RankingAdapter(List<Language> languageList)
		{
			LanguageList = languageList;
		}

		public override int ItemCount
		{
			get
			{
				return LanguageList.Count;
			}
		}

		public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
		{
			var rankingHolder = holder as RankingHolder;
			var language = LanguageList[position];

			int resID = Android.App.Application.Context.Resources.GetIdentifier(language.ImageName, "drawable", Android.App.Application.Context.PackageName);
			rankingHolder.IVIcon.SetImageResource(resID);

			rankingHolder.TVLanguageName.Text = language.LanguageName;
			rankingHolder.TVDeveloperCompany.Text = language.DeveloperCompany;
		}

		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			View itemView = LayoutInflater.From(parent.Context).
					Inflate(Resource.Layout.language_card, parent, false);

			RankingHolder headerHolder = new RankingHolder(itemView);
			return headerHolder;
			
		}

		public void OnItemDismiss(int position)
		{
			LanguageList.RemoveAt(position);
			this.NotifyItemRemoved(position);

		}

		public void OnItemMove(int fromPosition, int toPosition)
		{
			if (fromPosition < toPosition)
			{
				for (int i = fromPosition; i < toPosition; i++)
				{
					Swap(LanguageList, i, i + 1);
				}
			}
			else {
				for (int i = fromPosition; i > toPosition; i--)
				{
					Swap(LanguageList, i, i - 1);
				}
			}
			NotifyItemMoved(fromPosition, toPosition);
		}

		public static void Swap(IList<Language> list, int indexA, int indexB)
		{
			Language tmp = list[indexA];
			list[indexA] = list[indexB];
			list[indexB] = tmp;
		}
	}
}

