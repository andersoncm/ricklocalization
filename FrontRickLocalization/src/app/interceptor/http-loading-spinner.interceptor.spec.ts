import { TestBed } from '@angular/core/testing';

import { HttpLoadingSpinnerInterceptor } from './http-loading-spinner.interceptor';

describe('HttpLoadingSpinnerInterceptor', () => {
  beforeEach(() => TestBed.configureTestingModule({
    providers: [
      HttpLoadingSpinnerInterceptor
      ]
  }));

  it('should be created', () => {
    const interceptor: HttpLoadingSpinnerInterceptor = TestBed.inject(HttpLoadingSpinnerInterceptor);
    expect(interceptor).toBeTruthy();
  });
});
