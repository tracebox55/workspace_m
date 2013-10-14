//
// 関連するボーンが存在しない剛体を削除する
// [簡易形式]DeleteUnlinkedBodies.cx
//
for (int i = body.Count - 1; i >= 0; i--)
{
    if (body[i].Bone == null)   // 関連するボーンが存在しない
    {
        body.RemoveAt(i);
    }
}
// 結果を反映
connect.Pmx.Update(pmx);
// 各種更新
connect.Form.UpdateList(UpdateObject.Body);
connect.View.PMDView.UpdateModel();
connect.View.PMDView.UpdateView();
