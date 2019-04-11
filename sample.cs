ReadMore.GestureRecognizers.Add(new TapGestureRecognizer
{
    Command = new Command(() => OnLabelClicked()),
});


private void OnLabelClicked()
{
    if(ReadMore.Text == "Read more") {
        ComplaintDetails.LineBreakMode = LineBreakMode.WordWrap;
        ComplaintDetails.Lines = -1;
        ReadMore.Text = AppResources.Read_less;
    }
    else 
    {
        ComplaintDetails.LineBreakMode = LineBreakMode.TailTruncation;
        ComplaintDetails.Lines = 2;
        ReadMore.Text = AppResources.Read_more;
    }
}