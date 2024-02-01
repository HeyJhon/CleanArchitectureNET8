namespace JFMSystems.Presenters;

public interface IPresenter<FormDataType>
{
    public FormDataType Content { get; }
}