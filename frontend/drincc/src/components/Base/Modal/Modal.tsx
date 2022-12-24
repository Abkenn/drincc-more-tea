import React, { useEffect, useState } from 'react';
import Draggable from 'react-draggable';
import Button from '@mui/material/Button';
import Dialog from '@mui/material/Dialog';
import DialogActions from '@mui/material/DialogActions';
import DialogContent from '@mui/material/DialogContent';
import DialogContentText from '@mui/material/DialogContentText';
import DialogTitle from '@mui/material/DialogTitle';
import Paper, { PaperProps } from '@mui/material/Paper';
import { isNonEmptyString } from '../../../utils';

const draggableHandle = 'draggable-modal-title';

const PaperComponent = (props: PaperProps) => (
  <Draggable
    handle={`#${draggableHandle}`}
    cancel={'[class*="MuiDialogContent-root"]'}
  >
    <Paper {...props} />
  </Draggable>
);

export const DraggableDialog: React.FunctionComponent<{
  title?: string,
  description?: string,
  children?: React.ReactNode,
  active?: boolean,
  onClose?: () => void
}> = ({
  active = false, title, description, children, onClose
}) => {
  const renderModalContent = () => {
    if (children === undefined && isNonEmptyString(description)) {
      return (
        <DialogContentText>
          {description}
        </DialogContentText>
      );
    }
    return children;
  };

  const renderComponent = () => {
    if (active) {
      return (
        <div>
          <Dialog
            open={active}
            onClose={onClose}
            PaperComponent={PaperComponent}
            aria-labelledby={draggableHandle}
          >
            <DialogTitle style={{ cursor: 'move' }} id={draggableHandle}>
              {title}
            </DialogTitle>
            <DialogContent>
              {renderModalContent()}
            </DialogContent>
            <DialogActions>
              <Button autoFocus onClick={onClose}>
                Cancel
              </Button>
              <Button onClick={onClose}>Save</Button>
            </DialogActions>
          </Dialog>
        </div>
      );
    }
    return null;
  };

  return renderComponent();
};

export default DraggableDialog;
