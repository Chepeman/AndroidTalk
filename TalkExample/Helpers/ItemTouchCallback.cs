using System;
using Android.Support.V7.Widget;
using Android.Support.V7.Widget.Helper;
namespace TalkExample
{
	public class ItemTouchCallback : ItemTouchHelper.Callback
	{
		RankingAdapter Adapter;

		public ItemTouchCallback(RankingAdapter adapter)
		{
			Adapter = adapter;
		}

		public override int GetMovementFlags(RecyclerView recyclerView, RecyclerView.ViewHolder viewHolder)
		{
			int dragFlags = ItemTouchHelper.Up | ItemTouchHelper.Down;
			int swipeFlags = ItemTouchHelper.Start | ItemTouchHelper.End;
			return MakeMovementFlags(dragFlags, swipeFlags);
		}

		public override bool OnMove(RecyclerView recyclerView, RecyclerView.ViewHolder viewHolder, RecyclerView.ViewHolder target)
		{
			Adapter.OnItemMove(viewHolder.AdapterPosition, target.AdapterPosition);
			return true;
		}

		public override void OnSwiped(RecyclerView.ViewHolder viewHolder, int direction)
		{
			Adapter.OnItemDismiss(viewHolder.AdapterPosition);
		}

		public override bool IsLongPressDragEnabled
		{
			get
			{
				return true;
			}
		}

		public override bool IsItemViewSwipeEnabled
		{
			get
			{
				return true;
			}
		}
	}
}

