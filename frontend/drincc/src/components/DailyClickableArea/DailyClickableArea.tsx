/* eslint-disable jsx-a11y/no-static-element-interactions */
/* eslint-disable jsx-a11y/click-events-have-key-events */
import { useState } from 'react';
import classNames from 'classnames';
import TeaSelect from '../TeaSelect/TeaSelect';

const DailyClickableArea: React.FunctionComponent<{
  teaSessions: number[],
  onAddTeaSession?: (id: number) => void;
}> = ({ teaSessions }) => {
  const [isClicked, setIsClicked] = useState(false);
  return (
    <div
      className="daily-clickable-area"
      onClick={() => setIsClicked(!isClicked)}
    >
      <div className="daily-clickable-area__sessions">
        {[-1, ...teaSessions].map((session, index) => {
          const shouldHideSelect = index === 0 && isClicked;
          return (
            <div className={classNames({
              'daily-clickable-area__session-item': true,
              'daily-clickable-area__session-item--hidden': shouldHideSelect
            })}
            >
              {shouldHideSelect ? (
                <TeaSelect />
              ) : index !== 0 && (
                <div className="daily-clickable-area__session-item__title">
                  {session}
                </div>
              )}
            </div>
          );
        })}
      </div>
    </div>
  );
};

export default DailyClickableArea;
