//
// 接続剛体のないJOINTを削除する
// [簡易形式]DeleteUnlinkedJoionts.cx
for (int i = joint.Count - 1; i >= 0; i--)
{
    if (joint[i].BodyA == null || joint[i].BodyB == null)   // 接続剛体が存在しない
    {
        joint.RemoveAt(i);
    }
}
// 結果を反映
connect.Pmx.Update(pmx);
// 各種更新
connect.Form.UpdateList(UpdateObject.Joint);
connect.View.PMDView.UpdateModel();
connect.View.PMDView.UpdateView();

