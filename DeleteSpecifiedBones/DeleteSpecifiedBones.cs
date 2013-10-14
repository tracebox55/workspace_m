//
// 指定した名前が含まれるボーンを削除する
// [簡易形式]DeleteSpecifiedBones.cx
//
string name = "スカート";	// ボーン名（一部）
for (int i = bone.Count - 1; i >= 0; i--)
{
    if (bone[i].Name.IndexOf(name) > 0)
    {
        bone.RemoveAt(i);
    }
}
// 結果を反映
connect.Pmx.Update(pmx);
// 各種更新
connect.Form.UpdateList(UpdateObject.Bone);
connect.View.PMDView.UpdateModel();
connect.View.PMDView.UpdateView();
