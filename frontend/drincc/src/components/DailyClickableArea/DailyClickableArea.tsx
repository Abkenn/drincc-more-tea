/* eslint-disable jsx-a11y/no-static-element-interactions */
/* eslint-disable jsx-a11y/click-events-have-key-events */
import { useState } from 'react';
import classNames from 'classnames';
import Modal from '../Base/Modal/Modal';
import TeaSelect from '../TeaSelect/TeaSelect';
import './index.scss';

const DailyClickableArea: React.FunctionComponent<{
  teaSessions: number[],
  onAddTeaSession?: (id: number) => void;
}> = ({ teaSessions }) => {
  const [isClicked, setIsClicked] = useState(false);
  const [isModalActive, setIsModalActive] = useState(false);

  return (
    <div
      className="daily-clickable-area"
      onClick={() => setIsClicked(!isClicked)}
    >
      <div className="daily-clickable-area__sessions">
        {[-1, ...teaSessions].map((session, index) => {
          const shouldHideSelect = index === 0 && !isClicked;
          return (
            <div className={classNames({
              'daily-clickable-area__session-item': true,
              'daily-clickable-area__session-item--hidden': shouldHideSelect
            })}
            >

              {index === 0 && (
                <Modal active={isModalActive} onClose={() => setIsModalActive(false)} description="test">
                  <TeaSelect />
                </Modal>
              )}
              {index !== 0 && (
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
