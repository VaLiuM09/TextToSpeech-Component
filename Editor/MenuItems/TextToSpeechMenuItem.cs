using VPG.Creator.Core.Behaviors;
using VPG.Creator.TextToSpeech.Audio;
using VPG.Creator.Core.Internationalization;
using VPG.CreatorEditor.UI.StepInspector.Menu;

namespace VPG.CreatorEditor.TextToSpeech.UI.Behaviors
{
    /// <inheritdoc />
    public class TextToSpeechMenuItem : MenuItem<IBehavior>
    {
        /// <inheritdoc />
        public override string DisplayedName { get; } = "Audio/Play TextToSpeech Audio";

        /// <inheritdoc />
        public override IBehavior GetNewItem()
        {
            return new PlayAudioBehavior(new TextToSpeechAudio(new LocalizedString()), BehaviorExecutionStages.Activation, true);
        }
    }
}
